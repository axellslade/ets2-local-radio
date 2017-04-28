using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS2_Local_Radio_server.Logic;

namespace ETS2_Local_Radio_server.UI
{
    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();
        }

        private void InfoView_Load(object sender, EventArgs e)
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    comboIP.Items.Add("http://" + ip.ToString() + ":" + Settings.Port);
                }
            }
            comboIP.SelectedIndex = 0;
        }

        private void URLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(comboIP.SelectedItem.ToString());
        }
    }
}
