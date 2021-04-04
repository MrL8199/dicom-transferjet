﻿namespace MyChat
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFile = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 70);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(585, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 70);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "---";
            this.toolTip1.SetToolTip(this.btnMinimize, "Thu nhỏ chương trình");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(635, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 70);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.toolTip1.SetToolTip(this.btnExit, "Thoát chương trình");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnImage);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Location = new System.Drawing.Point(181, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 79);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 40);
            this.panel4.TabIndex = 7;
            this.toolTip1.SetToolTip(this.panel4, "Nhập tin nhắn...");
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(5, 11);
            this.txtMessage.MaxLength = 500;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(375, 18);
            this.txtMessage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMessage, "Nhập tin nhắn...");
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.OldLace;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(401, 15);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(40, 40);
            this.btnImage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnImage, "Gửi tập tin đính kèm");
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(441, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 40);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "GỬI";
            this.toolTip1.SetToolTip(this.btnSend, "Gửi tin nhắn");
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // webMain
            // 
            this.webMain.IsWebBrowserContextMenuEnabled = false;
            this.webMain.Location = new System.Drawing.Point(182, 76);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(501, 294);
            this.webMain.TabIndex = 2;
            this.webMain.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webMain.WebBrowserShortcutsEnabled = false;
            this.webMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webMain_Navigating);
            // 
            // pnlFile
            // 
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Controls.Add(this.lblFile);
            this.pnlFile.Controls.Add(this.prgFile);
            this.pnlFile.Location = new System.Drawing.Point(182, 289);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(500, 81);
            this.pnlFile.TabIndex = 5;
            this.pnlFile.Visible = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(122, 19);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Đang nhận dữ liệu";
            // 
            // prgFile
            // 
            this.prgFile.Location = new System.Drawing.Point(15, 47);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(476, 25);
            this.prgFile.Step = 1;
            this.prgFile.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(2, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 174);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.User.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.User.Location = new System.Drawing.Point(2, 262);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(174, 48);
            this.User.TabIndex = 7;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(15, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mở file DICOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(685, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.webMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Activated += new System.EventHandler(this.frmClient_Activated);
            this.Deactivate += new System.EventHandler(this.frmClient_Deactived);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmClient_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ProgressBar prgFile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button button1;
    }
}