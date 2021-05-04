using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxAndHounds.Server
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            labelIp.Text = "IP Address: " + ipAddress.MapToIPv4().ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NetworkServer networkServer = new NetworkServer(Convert.ToInt32(textBoxPort.Text));
            networkServer.StartServer();
        }
    }
}
