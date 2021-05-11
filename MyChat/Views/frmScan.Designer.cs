namespace MyChat
{
    partial class frmScan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkOther = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lnkOther);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picQRCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 445);
            this.panel2.TabIndex = 1;
            // 
            // lnkOther
            // 
            this.lnkOther.AutoSize = true;
            this.lnkOther.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lnkOther.Location = new System.Drawing.Point(363, 393);
            this.lnkOther.Name = "lnkOther";
            this.lnkOther.Size = new System.Drawing.Size(80, 19);
            this.lnkOther.TabIndex = 2;
            this.lnkOther.TabStop = true;
            this.lnkOther.Text = "địa chỉ khác";
            this.lnkOther.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOther_LinkClicked);
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.Location = new System.Drawing.Point(0, 56);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(480, 40);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "(NULL)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nếu ghép nối không thành công có thể sử dụng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "hoặc dùng điện thoại quét mã QR code sau";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mở DICOM Transferjet trên điện thoại hoặc một máy tính khác\r\nsử dụng địa chỉ sau " +
    "để kết nối";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(115, 137);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(250, 250);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQRCode.TabIndex = 0;
            this.picQRCode.TabStop = false;
            // 
            // frmScan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(520, 525);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết nối";
            this.Load += new System.EventHandler(this.frmScan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.LinkLabel lnkOther;
        private System.Windows.Forms.Label label4;
    }
}