using Dicom;
using Dicom.Imaging;
using MyChat.DicomLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyChat.Views.ReadDicom
{
    public partial class frmDicomReader : MetroFramework.Forms.MetroForm
    {
        bool imageOpened;

        Dicom.DicomFile file;
        List<string> fileTags = new List<string>();

        public frmDicomReader()
        {
            InitializeComponent();
        }

        public frmDicomReader(string pathFile)
        {
            InitializeComponent();
            string fileName = Path.GetFileName(pathFile);
            if (fileName.Length > 0)
            {
                //Cursor = Cursors.WaitCursor;
                ReadAndDisplayDicomFile(fileName, fileName);
                imageOpened = true;
                //Cursor = Cursors.Default;
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
                    //Cursor = Cursors.WaitCursor;
                    ReadAndDisplayDicomFile(ofd.FileName, ofd.SafeFileName);
                    imageOpened = true;
                    //Cursor = Cursors.Default;
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
            IImage image = new DicomImage(fileName).RenderImage();
            Bitmap bmp = image.AsBitmap();
            this.pictureBox1.Image = bmp;

            SetString();
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
            //if (imagePanelControl != null) imagePanelControl.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageOpened == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Files(*.png)|*.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                    Console.WriteLine("hi");
                    //imagePanelControl.SaveImage(sfd.FileName);
            }
            else
                MessageBox.Show("Vui lòng mở file DICOM trước khi chọn tính năng này!", "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
