namespace MyChat.Views
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
            this.lblFile = new System.Windows.Forms.Label();
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.btnSend1 = new MetroFramework.Controls.MetroLink();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.openDICOMFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humbugerMenu = new MetroFramework.Controls.MetroLink();
            this.btnImage1 = new MetroFramework.Controls.MetroLink();
            this.pnlFile.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFile.Location = new System.Drawing.Point(11, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(122, 19);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Đang nhận dữ liệu";
            // 
            // prgFile
            // 
            this.prgFile.Location = new System.Drawing.Point(15, 39);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(510, 25);
            this.prgFile.Step = 1;
            this.prgFile.TabIndex = 0;
            // 
            // pnlFile
            // 
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Controls.Add(this.lblFile);
            this.pnlFile.Controls.Add(this.prgFile);
            this.pnlFile.Location = new System.Drawing.Point(0, 440);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(540, 80);
            this.pnlFile.TabIndex = 12;
            this.pnlFile.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(75, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 40);
            this.panel4.TabIndex = 7;
            this.toolTip1.SetToolTip(this.panel4, "Nhập tin nhắn...");
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(5, 11);
            this.txtMessage.MaxLength = 500;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(385, 18);
            this.txtMessage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMessage, "Nhập tin nhắn...");
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // webMain
            // 
            this.webMain.IsWebBrowserContextMenuEnabled = false;
            this.webMain.Location = new System.Drawing.Point(0, 60);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(540, 460);
            this.webMain.TabIndex = 11;
            this.toolTip1.SetToolTip(this.webMain, "Nội dung chat..");
            this.webMain.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webMain.WebBrowserShortcutsEnabled = false;
            this.webMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webMain_Navigating);
            // 
            // btnSend1
            // 
            this.btnSend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnSend1.BackgroundImage = global::MyChat.Properties.Resources.send_btn_no_hover1;
            this.btnSend1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSend1.Image = global::MyChat.Properties.Resources.send_btn_no_hover1;
            this.btnSend1.ImageSize = 38;
            this.btnSend1.Location = new System.Drawing.Point(485, 15);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.NoFocusImage = global::MyChat.Properties.Resources.send_btn;
            this.btnSend1.Size = new System.Drawing.Size(40, 40);
            this.btnSend1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnSend1, "Gửi tin nhắn");
            this.btnSend1.UseSelectable = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Image = global::MyChat.Properties.Resources.send_btn;
            this.btnSend.Location = new System.Drawing.Point(485, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSend, "Gửi tin nhắn");
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnImage1);
            this.panel2.Controls.Add(this.btnSend1);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 70);
            this.panel2.TabIndex = 10;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDICOMFileToolStripMenuItem,
            this.dToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(292, 70);
            // 
            // openDICOMFileToolStripMenuItem
            // 
            this.openDICOMFileToolStripMenuItem.Name = "openDICOMFileToolStripMenuItem";
            this.openDICOMFileToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.openDICOMFileToolStripMenuItem.Text = "Mở Trình đọc file &DICOM";
            this.openDICOMFileToolStripMenuItem.Click += new System.EventHandler(this.openDICOMFileToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(288, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.exitToolStripMenuItem.Text = "&Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // humbugerMenu
            // 
            this.humbugerMenu.Image = global::MyChat.Properties.Resources.humburger_menu64;
            this.humbugerMenu.ImageSize = 42;
            this.humbugerMenu.Location = new System.Drawing.Point(485, 13);
            this.humbugerMenu.Name = "humbugerMenu";
            this.humbugerMenu.NoFocusImage = global::MyChat.Properties.Resources.humburger_menu_no_hover;
            this.humbugerMenu.Size = new System.Drawing.Size(45, 41);
            this.humbugerMenu.TabIndex = 13;
            this.humbugerMenu.UseSelectable = true;
            this.humbugerMenu.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // btnImage1
            // 
            this.btnImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnImage1.BackgroundImage = global::MyChat.Properties.Resources.attachment2;
            this.btnImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImage1.Image = global::MyChat.Properties.Resources.attachment_hover1;
            this.btnImage1.ImageSize = 38;
            this.btnImage1.Location = new System.Drawing.Point(15, 15);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.NoFocusImage = global::MyChat.Properties.Resources.attachment2;
            this.btnImage1.Size = new System.Drawing.Size(40, 40);
            this.btnImage1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnImage1, "Gửi tập tin đính kèm");
            this.btnImage1.UseSelectable = true;
            this.btnImage1.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 590);
            this.ControlBox = false;
            this.Controls.Add(this.humbugerMenu);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.webMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.Text = "DICOM Transferjet Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ProgressBar prgFile;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.Button btnSend;
        private MetroFramework.Controls.MetroLink humbugerMenu;
        private MetroFramework.Controls.MetroContextMenu ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem openDICOMFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroLink btnSend1;
        private MetroFramework.Controls.MetroLink btnImage1;
    }
}