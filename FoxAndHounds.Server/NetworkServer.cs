using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FoxAndHounds.Server
{
    public class NetworkServer
    {
        public TcpListener TcpListener { get; set; }
        public NetworkServer(Int32 port)
        {
            var ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            TcpListener = new TcpListener(ipAddress, port);
        }

        public void StartServer()
        {
            TcpListener.Start();
        }

        public void AcceptConnection()
        {
            throw new NotImplementedException();
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