using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHound.Classes
{
    public delegate void DataRead(string data);

    public class NetworkClient
    {
        public TcpClient TcpClient { get; set; }

        public event DataRead OnDataRead;
        public NetworkClient()
        {
            TcpClient = new TcpClient();
        }

        public void Connect(string IP, Int32 port)
        {
            TcpClient.Connect(IPAddress.Parse(IP), port);
        }

        public void Write(string data)
        {

        }

        public async Task Read()
        {
            var clientStream = TcpClient.GetStream();
            var buffer = new byte[1000];
            while (TcpClient.Connected)
            {
                await clientStream.ReadAsync(buffer, 0, buffer.Length);
                string data = ;

            }
        }
    }
}
