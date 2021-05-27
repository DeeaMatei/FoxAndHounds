using System;
using System.Windows.Forms;
using FoxAndHound.Classes;

namespace FoxAndHounds
{
    public partial class ConnectScreen : Form
    {
        public NetworkClient networkClient;

        public ConnectScreen(NetworkClient networkClient)
        {
            InitializeComponent();
            this.networkClient = networkClient;
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            networkClient.Connect(textIp.Text, Convert.ToInt32(textPort.Text));
            networkClient.Read();
            networkClient.Read();
        }
    }
}