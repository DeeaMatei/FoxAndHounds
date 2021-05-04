using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes
{
    public class NetworkClient
    {
        public TcpClient TcpClient { get; set; }
        public NetworkClient()
        {
            TcpClient = new TcpClient();

        }

        public void Connect(string IP, Int32 port)
        {
            TcpClient.Connect(IP, port);
        }
    }
}
