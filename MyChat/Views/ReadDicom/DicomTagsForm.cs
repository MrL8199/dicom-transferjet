using System.Collections.Generic;
using System.Windows.Forms;

// Program to view simple DICOM images.
// Written by Amarnath S, Mahesh Reddy S, Bangalore, India, April 2009.
// Updated by Amarnath, July 2010 to include "Save As Text".

namespace MyChat
{
    public partial class DicomTagsForm : Form
    {
        List<string> str;

        public DicomTagsForm()
        {
            InitializeComponent();
        }

        // Extract the substrings within the DICOM tags main string 
        //  to populate the list box
        public void SetString(ref List<string> strg)
        {
            str = strg;
            string inputTag, tagDescription, value, groupTag, elementTag;

            // Add items to the List View Control
            for (int i = 0; i < str.Count; ++i)
            {
                inputTag = str[i];
                ExtractStrings(inputTag, out tagDescription, out value, out groupTag, out elementTag);

                ListViewItem lvi = new ListViewItem(groupTag);
                lvi.SubItems.Add(elementTag);
                lvi.SubItems.Add(tagDescription);
                lvi.SubItems.Add(value);
                listView.Items.Add(lvi);
            }
        }

        private void bnSaveAs_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT Files(*.txt)|*.txt";
            string s1, s4, s5, s11, s12;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(sfd.FileName);
                for (int i = 0; i < str.Count; ++i)
                {
                    s1 = str[i];
                    ExtractStrings(s1, out s4, out s5, out s11, out s12);
                    file.WriteLine("(" + s11 + "," + s12 + ")\t" + s4 + "\t\t" + s5);
                }
                file.Close();
            }
        }

        // This method was extracted using the Refactoring facility in Visual Studio
        void ExtractStrings(string inputTag, out string tagDescription, out string value, out string groupTag, out string elementTag)
        {
            //(0010,0010) PN Patient's Name|Anonymized
            // split -> ["(0010,0010) PN Patient's Name", "Anonymized"]
            // grouptag = substring(0, 10)
            // description = 

            string tag;
            string[] str = inputTag.Split('|');
            value = str[1];
            tag = str[0];

            groupTag = tag.Substring(1, 4);
            elementTag = tag.Substring(6, 4);
            tagDescription = tag.Substring(11);
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
