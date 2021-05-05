﻿using System;
using System.Windows.Forms;

namespace FoxAndHounds
{
    public partial class MainMenu : Form
    {
        public HelpScreen helpScreen;
        public ConnectScreen connectScreen;
        public MainScreen mainScreen;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            helpScreen = new HelpScreen();
            helpScreen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (helpScreen != null)
            {
                helpScreen.Close();
            }
            if (mainScreen != null)
            {
                mainScreen.Close();
            }
            if (connectScreen != null)
            {
                connectScreen.Close();
            }
        }

        private void btnVsComputer_Click(object sender, EventArgs e)
        {
            mainScreen = new MainScreen();
            mainScreen.FormClosed += OnFormsClosed;
            mainScreen.Show();
            this.Hide();
        }

        private void btnPvpLocal_Click(object sender, EventArgs e)
        {
            mainScreen = new MainScreen();
            mainScreen.FormClosed += OnFormsClosed;
            mainScreen.Show();
            this.Hide();
        }

        private void btnPvpLan_Click(object sender, EventArgs e)
        {
            connectScreen = new ConnectScreen();
            connectScreen.FormClosed += OnFormsClosed;
            connectScreen.Show();
            this.Hide();
        }

        public void OnFormsClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}