﻿using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace FoxAndHounds.Server
{
    public partial class MainForm : Form
    {
        public NetworkServer NetworkServer { get; set; }

        public MainForm()
        {
            InitializeComponent();
            var ipAddressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            IPAddress ipAddress = IPAddress.Any;
            foreach (var address in ipAddressList)
            {
                if (address.AddressFamily.Equals(AddressFamily.InterNetwork))
                    ipAddress = address;
            }
            labelIp.Text = "IP Address: " + ipAddress.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (NetworkServer == null)
            {
                NetworkServer = new NetworkServer(Convert.ToInt32(textBoxPort.Text));
                NetworkServer.StartServer();
                labelServerOn.Text = "Server is running.";
                labelStatusColor.BackColor = Color.Green;
                btnStart.Text = "Stop Server";
                NetworkServer.AcceptConnection().ContinueWith(callback =>
                {
                    textLogs.Text += Environment.NewLine + "Client " + callback.Result.ToString() + " connected!";
                    NetworkServer.AcceptConnection().ContinueWith(callback2 =>
                    {
                        textLogs.Text += Environment.NewLine + "Client " + callback2.Result.ToString() + " connected!";
                    });
                });

                textLogs.Text += "\r\n Server listening on: " + NetworkServer.TcpListener.LocalEndpoint;
            }
            else
            {
                NetworkServer.StopServer();
                NetworkServer = null;
                labelServerOn.Text = "Server is stopped.";
                labelStatusColor.BackColor = Color.Red;
                btnStart.Text = "Start Server";
            }
        }
    }
}