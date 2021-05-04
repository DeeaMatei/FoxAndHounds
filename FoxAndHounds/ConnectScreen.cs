using System;
using System.Windows.Forms;
using FoxAndHound.Classes;

namespace FoxAndHounds
{
    public partial class ConnectScreen : Form
    {
        public ConnectScreen()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            NetworkClient networkClient = new NetworkClient();
            networkClient.Connect(textIp.Text, Convert.ToInt32(textPort.Text));
        }
    }
}