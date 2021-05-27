using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxAndHound.Classes
{
    public delegate void DataRead(string data, NetworkClient networkClient);
    public delegate void GameStarted();

    public class NetworkClient
    {
        public TcpClient TcpClient { get; set; }

        public event DataRead OnDataRead;
        public event GameStarted OnGameStarted;
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
            if (TcpClient.Connected)
            { // Call Write on move
                BinaryWriter binaryWriter = new BinaryWriter(TcpClient.GetStream());
                binaryWriter.Write(data);
                binaryWriter.Flush();
            }
        }

        public void Read()
        {
            BinaryReader binaryReader = new BinaryReader(TcpClient.GetStream());
            if (TcpClient.Connected)
            {
                var text = binaryReader.ReadString();
                if (text.Equals("start"))
                {
                   OnGameStarted?.Invoke();
                }
                else
                {
                    OnDataRead?.Invoke(text, this);
                }
            }
        }

        public void OnDataSent (Move move)
        {
            string data = move.Start.ToString()+"-"+move.Destination.ToString();
            this.Write(data);
            this.Read();
        }
    }
}
