using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxAndHound.Classes;

namespace FoxAndHounds
{
    public partial class ConnectScreen : Form
    {
        public NetworkClient networkClient;
        public ConnectScreen()
        {
            InitializeComponent();
            networkClient = new NetworkClient();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {   
            networkClient.Connect(textIp.Text, Convert.ToInt32(textPort.Text));
            Task.Run(()=> networkClient.Read());
        }
    }
}