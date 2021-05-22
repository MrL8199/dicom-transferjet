using Dicom;
using Dicom.Imaging;
using MyChat.DicomLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyChat.Views.ReadDicom
{
    public partial class frmDicomReader : MetroFramework.Forms.MetroForm
    {
        bool imageOpened;

        Dicom.DicomFile file;
        List<string> fileTags = new List<string>();
        PictureBox org;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        #region Form
        public frmDicomReader()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        public frmDicomReader(string pathFile)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            string fileName = Path.GetFileName(pathFile);
            if (fileName.Length > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                ReadAndDisplayDicomFile(fileName, fileName);
                imageOpened = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (imagePanelControl != null) imagePanelControl.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageOpened == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Files(*.png)|*.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        org.Image.Save(sfd.FileName, ImageFormat.Png);
                        MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi lưu file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    finally
                    {
                        sfd.Dispose();
                    }
                }
                //imagePanelControl.SaveImage(sfd.FileName);
            }
            else
                MessageBox.Show("Vui lòng mở file DICOM trước khi chọn tính năng này!", "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicute(org.Image, new Size(trackBar.Value, trackBar.Value));
            }
        }

        private void bnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All DICOM Files(*.dcm)|*.dcm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ReadAndDisplayDicomFile(ofd.FileName, ofd.SafeFileName);
                    imageOpened = true;
                    Cursor.Current = Cursors.Default;
                }
                ofd.Dispose();
            }
        }

        private void bnTags_Click(object sender, EventArgs e)
        {
            if (imageOpened == true)
            {
                DicomTagsForm dtg = new DicomTagsForm();
                dtg.SetString(ref fileTags);
                dtg.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng mở file DICOM trước khi xem Tags!", "Chú Ý !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Process image
        Image ZoomPicute(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void SaveVaryQualityLevel(Bitmap bmp, string path)
        {
            ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            bmp.Save(path, jgpEncoder,
                myEncoderParameters);
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        #endregion

        #region Read DICOM file
        private void ReadAndDisplayDicomFile(string fileName, string fileNameOnly)
        {
            file = DicomFile.Open(fileName);
            foreach (var tag in file.Dataset)
            {
                string str = ($"{tag}|{file.Dataset.GetValueOrDefault(tag.Tag, 0, "")}");
                fileTags.Add(str);
            }
            IImage image = new DicomImage(fileName).RenderImage();
            var dicomimg = new DicomImage(fileName);
            label_size.Text = dicomimg.Height.ToString() + "x" + dicomimg.Width.ToString() + " pixel";
            dicomimg.Scale = 1;

            Bitmap bmp = image.AsSharedBitmap();
            Size newSize = new Size((int)(dicomimg.Width * 2), (int)(dicomimg.Height * 2));
            bmp = new Bitmap(bmp, newSize);
            this.pictureBox1.Image = bmp;

            trackBar.Minimum = 1;
            trackBar.Maximum = 6;
            trackBar.SmallChange = 1;
            trackBar.LargeChange = 1;
            trackBar.UseWaitCursor = false;

            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox1.Image;

            SetString();
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
                if (groupTag == "0010" && elementTag == "0010")
                {
                    txtName.Text = value;
                }
                if (groupTag == "0010" && elementTag == "0040")
                {
                    txtSex.Text = value;
                }
                if (groupTag == "0010" && elementTag == "0020")
                {
                    txtID.Text = value;
                }
                if (groupTag == "0010" && elementTag == "0030")
                {
                    txtDOB.Text = value;
                }
                if (groupTag == "0010" && elementTag == "2154")
                {
                    txtPhone.Text = value;
                }
                if (groupTag == "0010" && elementTag == "1040")
                {
                    txtAddr.Text = value;
                }
                if (groupTag == "0018" && elementTag == "0015")
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
            lblSizeImage.Visible = true;
            label_size.Visible = true;
            trackBar.Visible = true;
            lblZoom.Visible = true;
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

        #endregion
    }
}
