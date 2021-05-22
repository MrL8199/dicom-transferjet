namespace MyChat.Views
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSender = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.panelBtnContainer = new System.Windows.Forms.Panel();
            this.ctxMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.openDICOMFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humbugerMenu = new MetroFramework.Controls.MetroLink();
            this.btnAddConnect1 = new MetroFramework.Controls.MetroLink();
            this.btnAddConnect = new System.Windows.Forms.Button();
            this.btnImage = new MetroFramework.Controls.MetroLink();
            this.btnSend1 = new MetroFramework.Controls.MetroLink();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFile.SuspendLayout();
            this.panelBtnContainer.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // webMain
            // 
            this.webMain.IsWebBrowserContextMenuEnabled = false;
            this.webMain.Location = new System.Drawing.Point(180, 60);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(575, 405);
            this.webMain.TabIndex = 7;
            this.webMain.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webMain.WebBrowserShortcutsEnabled = false;
            this.webMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webMain_Navigating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnImage);
            this.panel2.Controls.Add(this.btnSend1);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(180, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 70);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel4.Location = new System.Drawing.Point(65, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 40);
            this.panel4.TabIndex = 6;
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
            this.txtMessage.Size = new System.Drawing.Size(440, 18);
            this.txtMessage.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMessage, "Nhập tin nhắn...");
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.pnlSender);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 405);
            this.panel3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.panel3, "Danh sách client đang kết nối..");
            // 
            // pnlSender
            // 
            this.pnlSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.pnlSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSender.Location = new System.Drawing.Point(0, 0);
            this.pnlSender.Name = "pnlSender";
            this.pnlSender.Size = new System.Drawing.Size(180, 405);
            this.pnlSender.TabIndex = 1;
            this.toolTip1.SetToolTip(this.pnlSender, "Danh sách client đang kết nối..");
            this.pnlSender.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Không có client\r\nđang kết nối...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFile
            // 
            this.pnlFile.BackColor = System.Drawing.Color.White;
            this.pnlFile.Controls.Add(this.lblFile);
            this.pnlFile.Controls.Add(this.prgFile);
            this.pnlFile.Location = new System.Drawing.Point(180, 380);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(575, 85);
            this.pnlFile.TabIndex = 9;
            this.pnlFile.Visible = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(11, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(94, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Đang nhận dữ liệu";
            // 
            // prgFile
            // 
            this.prgFile.Location = new System.Drawing.Point(15, 39);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(545, 25);
            this.prgFile.Step = 1;
            this.prgFile.TabIndex = 0;
            // 
            // panelBtnContainer
            // 
            this.panelBtnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panelBtnContainer.Controls.Add(this.btnAddConnect1);
            this.panelBtnContainer.Controls.Add(this.btnAddConnect);
            this.panelBtnContainer.Location = new System.Drawing.Point(0, 465);
            this.panelBtnContainer.Name = "panelBtnContainer";
            this.panelBtnContainer.Size = new System.Drawing.Size(180, 70);
            this.panelBtnContainer.TabIndex = 13;
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
            this.openDICOMFileToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
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
            this.humbugerMenu.Location = new System.Drawing.Point(695, 13);
            this.humbugerMenu.Name = "humbugerMenu";
            this.humbugerMenu.NoFocusImage = global::MyChat.Properties.Resources.humburger_menu_no_hover;
            this.humbugerMenu.Size = new System.Drawing.Size(45, 41);
            this.humbugerMenu.TabIndex = 14;
            this.toolTip1.SetToolTip(this.humbugerMenu, "Menu");
            this.humbugerMenu.UseSelectable = true;
            this.humbugerMenu.Click += new System.EventHandler(this.humbugerMenu_Click);
            // 
            // btnAddConnect1
            // 
            this.btnAddConnect1.BackgroundImage = global::MyChat.Properties.Resources.add_client1;
            this.btnAddConnect1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddConnect1.Image")));
            this.btnAddConnect1.ImageSize = 52;
            this.btnAddConnect1.Location = new System.Drawing.Point(15, 10);
            this.btnAddConnect1.Name = "btnAddConnect1";
            this.btnAddConnect1.NoFocusImage = global::MyChat.Properties.Resources.add_client1;
            this.btnAddConnect1.Size = new System.Drawing.Size(52, 52);
            this.btnAddConnect1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnAddConnect1, "Thêm kết nối tới client");
            this.btnAddConnect1.UseSelectable = true;
            this.btnAddConnect1.Click += new System.EventHandler(this.btnAddConnect_Click);
            // 
            // btnAddConnect
            // 
            this.btnAddConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnAddConnect.FlatAppearance.BorderSize = 0;
            this.btnAddConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddConnect.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddConnect.Image = global::MyChat.Properties.Resources.add_client1;
            this.btnAddConnect.Location = new System.Drawing.Point(15, 10);
            this.btnAddConnect.Name = "btnAddConnect";
            this.btnAddConnect.Size = new System.Drawing.Size(52, 52);
            this.btnAddConnect.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAddConnect, "Thêm kết nối tới client");
            this.btnAddConnect.UseVisualStyleBackColor = false;
            this.btnAddConnect.Click += new System.EventHandler(this.btnAddConnect_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnImage.BackgroundImage = global::MyChat.Properties.Resources.attachment2;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImage.Image = global::MyChat.Properties.Resources.attachment_hover1;
            this.btnImage.ImageSize = 38;
            this.btnImage.Location = new System.Drawing.Point(15, 15);
            this.btnImage.Name = "btnImage";
            this.btnImage.NoFocusImage = global::MyChat.Properties.Resources.attachment2;
            this.btnImage.Size = new System.Drawing.Size(40, 40);
            this.btnImage.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnImage, "Gửi tập tin đính kèm");
            this.btnImage.UseSelectable = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSend1
            // 
            this.btnSend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnSend1.BackgroundImage = global::MyChat.Properties.Resources.send_btn_no_hover1;
            this.btnSend1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSend1.Image = global::MyChat.Properties.Resources.send_btn_no_hover1;
            this.btnSend1.ImageSize = 38;
            this.btnSend1.Location = new System.Drawing.Point(521, 15);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.NoFocusImage = global::MyChat.Properties.Resources.send_btn;
            this.btnSend1.Size = new System.Drawing.Size(40, 40);
            this.btnSend1.TabIndex = 16;
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
            this.btnSend.Location = new System.Drawing.Point(520, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSend, "Gửi tin nhắn");
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 535);
            this.ControlBox = false;
            this.Controls.Add(this.humbugerMenu);
            this.Controls.Add(this.panelBtnContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.webMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmServer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "DICOM Transferjet Server";
            this.Activated += new System.EventHandler(this.frmServer_Activated);
            this.Deactivate += new System.EventHandler(this.frmServer_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            this.panelBtnContainer.ResumeLayout(false);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ProgressBar prgFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBtnContainer;
        private System.Windows.Forms.Panel pnlSender;
        private System.Windows.Forms.Button btnAddConnect;
        private MetroFramework.Controls.MetroLink humbugerMenu;
        private MetroFramework.Controls.MetroContextMenu ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem openDICOMFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroLink btnAddConnect1;
        private MetroFramework.Controls.MetroLink btnSend1;
        private MetroFramework.Controls.MetroLink btnImage;
    }
}