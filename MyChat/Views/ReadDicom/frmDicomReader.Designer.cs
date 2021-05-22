namespace MyChat.Views.ReadDicom
{
    partial class frmDicomReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDicomReader));
            this.bnOpen = new MetroFramework.Controls.MetroButton();
            this.bnTags = new MetroFramework.Controls.MetroButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBodyPart = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtAddr = new MetroFramework.Controls.MetroTextBox();
            this.txtSex = new MetroFramework.Controls.MetroTextBox();
            this.txtDOB = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSizeImage = new MetroFramework.Controls.MetroLabel();
            this.label_size = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblZoom = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // bnOpen
            // 
            this.bnOpen.Location = new System.Drawing.Point(23, 63);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(115, 25);
            this.bnOpen.TabIndex = 0;
            this.bnOpen.Text = "Mở File";
            this.bnOpen.UseSelectable = true;
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnTags
            // 
            this.bnTags.Location = new System.Drawing.Point(23, 94);
            this.bnTags.Name = "bnTags";
            this.bnTags.Size = new System.Drawing.Size(115, 25);
            this.bnTags.TabIndex = 0;
            this.bnTags.Text = "Tất cả thẻ";
            this.bnTags.UseSelectable = true;
            this.bnTags.Click += new System.EventHandler(this.bnTags_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu ảnh ra PNG";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBodyPart);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddr);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Applemint", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(23, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // txtBodyPart
            // 
            // 
            // 
            // 
            this.txtBodyPart.CustomButton.Image = null;
            this.txtBodyPart.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtBodyPart.CustomButton.Name = "";
            this.txtBodyPart.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBodyPart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBodyPart.CustomButton.TabIndex = 1;
            this.txtBodyPart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBodyPart.CustomButton.UseSelectable = true;
            this.txtBodyPart.CustomButton.Visible = false;
            this.txtBodyPart.Lines = new string[0];
            this.txtBodyPart.Location = new System.Drawing.Point(109, 245);
            this.txtBodyPart.MaxLength = 32767;
            this.txtBodyPart.Name = "txtBodyPart";
            this.txtBodyPart.PasswordChar = '\0';
            this.txtBodyPart.ReadOnly = true;
            this.txtBodyPart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBodyPart.SelectedText = "";
            this.txtBodyPart.SelectionLength = 0;
            this.txtBodyPart.SelectionStart = 0;
            this.txtBodyPart.ShortcutsEnabled = true;
            this.txtBodyPart.Size = new System.Drawing.Size(127, 20);
            this.txtBodyPart.TabIndex = 4;
            this.txtBodyPart.UseSelectable = true;
            this.txtBodyPart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBodyPart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(109, 209);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = true;
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(127, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddr
            // 
            // 
            // 
            // 
            this.txtAddr.CustomButton.Image = null;
            this.txtAddr.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtAddr.CustomButton.Name = "";
            this.txtAddr.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddr.CustomButton.TabIndex = 1;
            this.txtAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddr.CustomButton.UseSelectable = true;
            this.txtAddr.CustomButton.Visible = false;
            this.txtAddr.Lines = new string[0];
            this.txtAddr.Location = new System.Drawing.Point(109, 173);
            this.txtAddr.MaxLength = 32767;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.PasswordChar = '\0';
            this.txtAddr.ReadOnly = true;
            this.txtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddr.SelectedText = "";
            this.txtAddr.SelectionLength = 0;
            this.txtAddr.SelectionStart = 0;
            this.txtAddr.ShortcutsEnabled = true;
            this.txtAddr.Size = new System.Drawing.Size(127, 20);
            this.txtAddr.TabIndex = 4;
            this.txtAddr.UseSelectable = true;
            this.txtAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSex
            // 
            // 
            // 
            // 
            this.txtSex.CustomButton.Image = null;
            this.txtSex.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtSex.CustomButton.Name = "";
            this.txtSex.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtSex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSex.CustomButton.TabIndex = 1;
            this.txtSex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSex.CustomButton.UseSelectable = true;
            this.txtSex.CustomButton.Visible = false;
            this.txtSex.Lines = new string[0];
            this.txtSex.Location = new System.Drawing.Point(109, 137);
            this.txtSex.MaxLength = 32767;
            this.txtSex.Name = "txtSex";
            this.txtSex.PasswordChar = '\0';
            this.txtSex.ReadOnly = true;
            this.txtSex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSex.SelectedText = "";
            this.txtSex.SelectionLength = 0;
            this.txtSex.SelectionStart = 0;
            this.txtSex.ShortcutsEnabled = true;
            this.txtSex.Size = new System.Drawing.Size(127, 20);
            this.txtSex.TabIndex = 4;
            this.txtSex.UseSelectable = true;
            this.txtSex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDOB
            // 
            // 
            // 
            // 
            this.txtDOB.CustomButton.Image = null;
            this.txtDOB.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtDOB.CustomButton.Name = "";
            this.txtDOB.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDOB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDOB.CustomButton.TabIndex = 1;
            this.txtDOB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDOB.CustomButton.UseSelectable = true;
            this.txtDOB.CustomButton.Visible = false;
            this.txtDOB.Lines = new string[0];
            this.txtDOB.Location = new System.Drawing.Point(109, 101);
            this.txtDOB.MaxLength = 32767;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.ReadOnly = true;
            this.txtDOB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDOB.SelectedText = "";
            this.txtDOB.SelectionLength = 0;
            this.txtDOB.SelectionStart = 0;
            this.txtDOB.ShortcutsEnabled = true;
            this.txtDOB.Size = new System.Drawing.Size(127, 20);
            this.txtDOB.TabIndex = 4;
            this.txtDOB.UseSelectable = true;
            this.txtDOB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDOB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(109, 65);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(109, 29);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(127, 20);
            this.txtID.TabIndex = 4;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 245);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Bộ phận chụp:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "SĐT:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Địa chỉ:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Giới tính:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Ngày sinh:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tên BN:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ID bệnh nhân:";
            // 
            // lblSizeImage
            // 
            this.lblSizeImage.AutoSize = true;
            this.lblSizeImage.Location = new System.Drawing.Point(23, 162);
            this.lblSizeImage.Name = "lblSizeImage";
            this.lblSizeImage.Size = new System.Drawing.Size(96, 19);
            this.lblSizeImage.TabIndex = 3;
            this.lblSizeImage.Text = "Kích thước ảnh:";
            this.lblSizeImage.Visible = false;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(125, 162);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(30, 19);
            this.label_size.TabIndex = 3;
            this.label_size.Text = "size";
            this.label_size.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(23, 194);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(48, 19);
            this.lblZoom.TabIndex = 3;
            this.lblZoom.Text = "Zoom:";
            this.lblZoom.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(287, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 466);
            this.panel1.TabIndex = 6;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(77, 194);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(188, 45);
            this.trackBar.TabIndex = 7;
            this.trackBar.Visible = false;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // frmDicomReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 552);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.lblSizeImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bnTags);
            this.Controls.Add(this.bnOpen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDicomReader";
            this.Text = "Trình Đọc File DICOM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bnOpen;
        private MetroFramework.Controls.MetroButton bnTags;
        private MetroFramework.Controls.MetroButton button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblSizeImage;
        private MetroFramework.Controls.MetroLabel label_size;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBodyPart;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtAddr;
        private MetroFramework.Controls.MetroTextBox txtSex;
        private MetroFramework.Controls.MetroTextBox txtDOB;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar;
    }
}