namespace MyChat.Views
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.clientToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.lbl_ipServer = new MetroFramework.Controls.MetroLabel();
            this.lblRunAsClient = new MetroFramework.Controls.MetroLabel();
            this.lblRunAsServer = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 60);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.ActiveControl = null;
            this.btnStart.Controls.Add(this.metroProgressSpinner);
            this.btnStart.Location = new System.Drawing.Point(516, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(264, 73);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Location = new System.Drawing.Point(197, 10);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(55, 55);
            this.metroProgressSpinner.TabIndex = 10;
            this.metroProgressSpinner.UseSelectable = true;
            this.metroProgressSpinner.Visible = false;
            // 
            // clientToggle
            // 
            this.clientToggle.AutoSize = true;
            this.clientToggle.Checked = true;
            this.clientToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientToggle.Location = new System.Drawing.Point(18, 69);
            this.clientToggle.Name = "clientToggle";
            this.clientToggle.Size = new System.Drawing.Size(80, 17);
            this.clientToggle.TabIndex = 7;
            this.clientToggle.Text = "On";
            this.clientToggle.UseSelectable = true;
            this.clientToggle.CheckedChanged += new System.EventHandler(this.clientToggle_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(18, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Khởi chạy như client ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.clientToggle);
            this.groupBox1.Controls.Add(this.lbl_ipServer);
            this.groupBox1.Controls.Add(this.lblRunAsClient);
            this.groupBox1.Controls.Add(this.lblRunAsServer);
            this.groupBox1.Location = new System.Drawing.Point(23, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServer.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtServer.Lines = new string[] {
        "127.0.0.1"};
            this.txtServer.Location = new System.Drawing.Point(155, 108);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(166, 25);
            this.txtServer.TabIndex = 9;
            this.txtServer.Text = "127.0.0.1";
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_ipServer
            // 
            this.lbl_ipServer.AutoSize = true;
            this.lbl_ipServer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_ipServer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_ipServer.Location = new System.Drawing.Point(165, 108);
            this.lbl_ipServer.Name = "lbl_ipServer";
            this.lbl_ipServer.Size = new System.Drawing.Size(81, 25);
            this.lbl_ipServer.TabIndex = 8;
            this.lbl_ipServer.Text = "IP Server";
            this.lbl_ipServer.Visible = false;
            // 
            // lblRunAsClient
            // 
            this.lblRunAsClient.AutoSize = true;
            this.lblRunAsClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRunAsClient.Location = new System.Drawing.Point(18, 108);
            this.lblRunAsClient.Name = "lblRunAsClient";
            this.lblRunAsClient.Size = new System.Drawing.Size(131, 25);
            this.lblRunAsClient.TabIndex = 8;
            this.lblRunAsClient.Text = "Nhập IP Server:";
            // 
            // lblRunAsServer
            // 
            this.lblRunAsServer.AutoSize = true;
            this.lblRunAsServer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRunAsServer.Location = new System.Drawing.Point(18, 108);
            this.lblRunAsServer.Name = "lblRunAsServer";
            this.lblRunAsServer.Size = new System.Drawing.Size(141, 25);
            this.lblRunAsServer.TabIndex = 8;
            this.lblRunAsServer.Text = "Địa chỉ IP Server:";
            this.lblRunAsServer.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.ActiveControl = null;
            this.btnExit.Location = new System.Drawing.Point(516, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 73);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "THOÁT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.Text = "DICOM Transferjet";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnStart.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnStart;
        private MetroFramework.Controls.MetroToggle clientToggle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroLabel lblRunAsClient;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroLabel lbl_ipServer;
        private MetroFramework.Controls.MetroLabel lblRunAsServer;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
    }
}