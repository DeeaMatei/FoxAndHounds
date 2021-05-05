using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndHounds.Server
{
    public class NetworkServer
    {
        public TcpListener TcpListener { get; set; }
        public TcpClient Client1 { get; set; }
        public TcpClient Client2 { get; set; }
        public NetworkServer(Int32 port)
        {
            var ipAddress = IPAddress.Any;
            TcpListener = new TcpListener(ipAddress, port);
        }

        public void StartServer()
        {
            TcpListener.Start();
        }

        public async Task<int> AcceptConnection()
        {
            if (Client1 == null)
            {
                Client1 = await TcpListener.AcceptTcpClientAsync();
                return 1;
            }
            else if (Client2 == null)
            {
                Client2 = await TcpListener.AcceptTcpClientAsync();
                return 2;
            }
            return 0;
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Send(string textToSend)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void StopServer()
        {
            TcpListener.Stop();
        }
    }
}