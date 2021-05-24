using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat.Views
{
    public partial class frmStart : MetroFramework.Forms.MetroForm
    {
        public frmStart()
        {
            InitializeComponent();
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    lbl_ipServer.Text = address.ToString();
                    txtServer.Text = address.ToString();
                }
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientToggle_CheckedChanged(object sender, EventArgs e)
        {
            MetroToggle toggle = (MetroToggle)sender;
            lbl_ipServer.Visible = !toggle.Checked;
            lblRunAsServer.Visible = !toggle.Checked;
            txtServer.Visible = toggle.Checked;
            lblRunAsClient.Visible = toggle.Checked;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            metroProgressSpinner.Visible = true;
            if (clientToggle.Checked)
            {
                // Client
                Setting.Mode = Setting.Modes.Client;
                // Connect to server 
                Setting.Server = txtServer.Text;

                try
                {

                    Setting.TcpServer = new TcpClient(Setting.Server, Setting.Port);
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối tới server");
                    metroProgressSpinner.Visible = false;
                    return;
                }
            }
            else
            {
                Setting.Mode = Setting.Modes.Server;
                // Start server
            }


            this.DialogResult = DialogResult.OK;
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            string folder = Properties.Settings.Default.FolderSave;
            if (folder.Equals(""))
            {
                folder = Directory.GetCurrentDirectory() + "/" + "Receive_file";
            }
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder); ;
            }
            Properties.Settings.Default.FolderSave = folder;
        }
    }
}
