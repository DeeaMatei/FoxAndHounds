using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            mainScreen.Show();
        }

        private void btnPvpLocal_Click(object sender, EventArgs e)
        {
            mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void btnPvpLan_Click(object sender, EventArgs e)
        {
            connectScreen = new ConnectScreen();
            connectScreen.Show();
        }
    }
}
