using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

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

        public async void AcceptConnection()
        {
            Client1 = await TcpListener.AcceptTcpClientAsync();
            //Client2 = await TcpListener.AcceptTcpClientAsync();
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