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
    public delegate void DataRead(string data);
    public delegate void GameStarted(NetworkClient client);

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
            TcpClient.ConnectAsync(IPAddress.Parse(IP), port);
        }

        public async Task Write(string data)
        {
            if (TcpClient.Connected)
            { // Call Write on move
                BinaryWriter binaryWriter = new BinaryWriter(TcpClient.GetStream());
                binaryWriter.Write(data);
            }
        }

        public async Task Read()
        {
            var stream = TcpClient.GetStream();
            var bytes = new byte[10];
            BinaryReader binaryReader = new BinaryReader(TcpClient.GetStream());
            while (TcpClient.Connected)
            {
                await stream.ReadAsync(bytes, (int)stream.Position, (int)stream.Length);
                var str = Convert.ToString(bytes);
                MessageBox.Show(str);
                if (str.Equals("start"))
                {
                    OnGameStarted?.Invoke(this);
                }
                else
                {
                    OnDataRead?.Invoke(str);
                }
            }
        }
    }
}
