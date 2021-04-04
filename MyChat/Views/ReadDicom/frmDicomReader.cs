using Dicom;
using MyChat.DicomLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyChat.Views.ReadDicom
{
    public partial class frmDicomReader : MetroFramework.Forms.MetroForm
    {
        DicomDecoder dd;
        List<byte> pixels8;
        List<ushort> pixels16;
        List<byte> pixels24;
        int imageWidth;
        int imageHeight;
        int bitDepth;
        int samplesPerPixel;
        bool imageOpened;
        double winCentre;
        double winWidth;
        bool signedImage;
        int maxPixelValue;
        int minPixelValue;

        Dicom.DicomFile file;
        List<string> fileTags = new List<string>();

        public frmDicomReader()
        {
            InitializeComponent();
            dd = new DicomDecoder();
            pixels8 = new List<byte>();
            pixels16 = new List<ushort>();
            pixels24 = new List<byte>();
            imageOpened = false;
            signedImage = false;
            maxPixelValue = 0;
            minPixelValue = 65535;
        }

        private void bnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All DICOM Files(*.dcm)|*.dcm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Length > 0)
                {
                    //Cursor = Cursors.WaitCursor;
                    ReadAndDisplayDicomFile(ofd.FileName, ofd.SafeFileName);
                    imageOpened = true;
                    Cursor = Cursors.Default;
                }
                ofd.Dispose();
            }
        }

        private void ReadAndDisplayDicomFile(string fileName, string fileNameOnly)
        {
            file = DicomFile.Open(fileName);
            foreach (var tag in file.Dataset)
            {
                string str = ($"{tag}|{file.Dataset.GetValueOrDefault(tag.Tag, 0, "")}");
                fileTags.Add(str);
            }

            dd.DicomFileName = fileName;

            TypeOfDicomFile typeOfDicomFile = dd.typeofDicomFile;

            if (typeOfDicomFile == TypeOfDicomFile.Dicom3File ||
                typeOfDicomFile == TypeOfDicomFile.DicomOldTypeFile)
            {
                label8.Visible = true;
                label_size.Visible = true;
                imageWidth = dd.width;
                imageHeight = dd.height;
                bitDepth = dd.bitsAllocated;
                winCentre = dd.windowCentre;
                winWidth = dd.windowWidth;
                samplesPerPixel = dd.samplesPerPixel;
                signedImage = dd.signedImage;
                bnTags.Enabled = true;
                imagePanelControl.NewImage = true;
                Text = "DICOM Image Viewer: " + fileNameOnly;
                label_size.Text = imageWidth.ToString() + " X " + imageHeight.ToString();

                if (samplesPerPixel == 1 && bitDepth == 8)
                {
                    pixels8.Clear();
                    pixels16.Clear();
                    pixels24.Clear();
                    dd.GetPixels8(ref pixels8);
                    minPixelValue = pixels8.Min();
                    maxPixelValue = pixels8.Max();
                    if (dd.signedImage)
                    {
                        winCentre -= char.MinValue;
                    }

                    if (Math.Abs(winWidth) < 0.001)
                    {
                        winWidth = maxPixelValue - minPixelValue;
                    }

                    if ((winCentre == 0) ||
                        (minPixelValue > winCentre) || (maxPixelValue < winCentre))
                    {
                        winCentre = (maxPixelValue + minPixelValue) / 2;
                    }

                    imagePanelControl.SetParameters(ref pixels8, imageWidth, imageHeight,
                        winWidth, winCentre, samplesPerPixel, true);
                }

                if (samplesPerPixel == 1 && bitDepth == 16)
                {
                    pixels16.Clear();
                    pixels8.Clear();
                    pixels24.Clear();
                    dd.GetPixels16(ref pixels16);
                    minPixelValue = pixels16.Min();
                    maxPixelValue = pixels16.Max();
                    if (dd.signedImage)
                    {
                        winCentre -= short.MinValue;
                    }

                    if (Math.Abs(winWidth) < 0.001)
                    {
                        winWidth = maxPixelValue - minPixelValue;
                    }

                    if ((winCentre == 0) ||
                        (minPixelValue > winCentre) || (maxPixelValue < winCentre))
                    {
                        winCentre = (maxPixelValue + minPixelValue) / 2;
                    }

                    imagePanelControl.Signed16Image = dd.signedImage;

                    imagePanelControl.SetParameters(ref pixels16, imageWidth, imageHeight,
                        winWidth, winCentre, true);
                }

                if (samplesPerPixel == 3 && bitDepth == 8)
                {
                    // This is an RGB colour image
                    pixels8.Clear();
                    pixels16.Clear();
                    pixels24.Clear();
                    dd.GetPixels24(ref pixels24);
                    imagePanelControl.SetParameters(ref pixels24, imageWidth, imageHeight,
                        winWidth, winCentre, samplesPerPixel, true);
                }
            }
            else
            {
                if (typeOfDicomFile == TypeOfDicomFile.DicomUnknownTransferSyntax)
                {
                    MessageBox.Show("Xin lỗi, File Dicom này không thể mở!",
                        "Chú Ý !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Xin lỗi, File này không tồn tại ảnh",
                        "Chú Ý !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Text = "DICOM Image Viewer: ";
                // Show a plain grayscale image instead
                pixels8.Clear();
                pixels16.Clear();
                pixels24.Clear();
                samplesPerPixel = 1;

                imageWidth = imagePanelControl.Width - 25;   // 25 is a magic number
                imageHeight = imagePanelControl.Height - 25; // Same magic number
                int iNoPix = imageWidth * imageHeight;

                for (int i = 0; i < iNoPix; ++i)
                {
                    pixels8.Add(240);// 240 is the grayvalue corresponding to the Control colour
                }
                winWidth = 256;
                winCentre = 127;
                imagePanelControl.SetParameters(ref pixels8, imageWidth, imageHeight,
                    winWidth, winCentre, samplesPerPixel, true);
                imagePanelControl.Invalidate();
                //bnSave.Enabled = false;
                bnTags.Enabled = false;
                label8.Visible = false;
                label_size.Visible = false;
            }

            List<string> lstString = dd.dicomInfo;
            SetString();
        }

        private void bnTags_Click(object sender, EventArgs e)
        {
            if (imageOpened == true)
            {
                DicomTagsForm dtg = new DicomTagsForm();
                dtg.SetString(ref fileTags);
                dtg.ShowDialog();
                imagePanelControl.Invalidate();
            }
            else
                MessageBox.Show("Vui lòng mở file DICOM trước khi xem Tags!", "Chú Ý !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SetString()
        {
            List<string> str = fileTags;
            string inputTag, tagDescription, value, groupTag, elementTag;

            // Add items to the List View Control
            for (int i = 0; i < str.Count; ++i)
            {
                inputTag = str[i];
                ExtractStrings(inputTag, out tagDescription, out value, out groupTag, out elementTag);
                if(groupTag == "0010" && elementTag == "0040")
                {
                    txtSex.Text = value;
                }
                if(groupTag == "0010" && elementTag == "0020")
                {
                    txtID.Text = value;
                }
                if(groupTag == "0010" && elementTag == "0030")
                {
                    txtDOB.Text = value;
                }
                if(groupTag == "0010" && elementTag == "2154")
                {
                    txtPhone.Text = value;
                }
                if(groupTag == "0010" && elementTag == "1040")
                {
                    txtAddr.Text = value;
                }
                if(groupTag == "0018" && elementTag == "0015")
                {
                    txtBodyPart.Text = value;
                }
            }

            txtID.Enabled = false;
            txtName.Enabled = false;
            txtDOB.Enabled = false;
            txtSex.Enabled = false;
            txtPhone.Enabled = false;
            txtBodyPart.Enabled = false;
            txtAddr.Enabled = false;
        }


        void ExtractStrings(string inputTag, out string tagDescription, out string value, out string groupTag, out string elementTag)
        {
            string tag;
            string[] str = inputTag.Split('|');
            value = str[1];
            tag = str[0];

            groupTag = tag.Substring(1, 4);
            elementTag = tag.Substring(6, 4);
            tagDescription = tag.Substring(11);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pixels8.Clear();
            pixels16.Clear();
            if (imagePanelControl != null) imagePanelControl.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageOpened == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Files(*.png)|*.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                    imagePanelControl.SaveImage(sfd.FileName);
            }
            else
                MessageBox.Show("Vui lòng mở file DICOM trước khi chọn tính năng này!", "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            imagePanelControl.Invalidate();
        }
    }
}
