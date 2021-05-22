using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace MyChat
{
    public partial class frmScan : MetroFramework.Forms.MetroForm
    {
        #region Khai Báo biến
        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

        List<string> lstIpAddress;
        int i = 0;
        #endregion

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        Bitmap GenerateQR(string s)
        {
            QRCodeEncoder qrencode = new QRCodeEncoder();
            qrencode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrencode.QRCodeScale = 5;
            qrencode.QRCodeVersion = 7;
            qrencode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            return qrencode.Encode(s);
        }

        void NextIp()
        {
            lblAddress.Text = lstIpAddress[i];
            picQRCode.Image = GenerateQR("mychat://" + lstIpAddress[i]);
            i++;
            if (i >= lstIpAddress.Count)
                i = 0;
        }

        public frmScan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.Padding = new Padding(1);

            lstIpAddress = new List<string>();
            lstIpAddress.Add(Dns.GetHostName());
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    lstIpAddress.Add(ip.ToString());
        }
        /// <summary>
        ///  Drop Shadow cho form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                // Bóng đổ
                cp.ClassStyle |= CS_DROPSHADOW;
                // Load các control cùng lúc
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void frmScan_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void frmScan_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmScan_Load(object sender, EventArgs e)
        {
            if (lstIpAddress.Count > 0)
                NextIp();
            else
                lnkOther.Enabled = false;
        }

        private void lnkOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NextIp();
        }

        private void frmScan_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
