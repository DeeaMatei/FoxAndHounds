using System;
using System.Windows.Forms;
using FoxAndHound.Classes;
using FoxAndHound.Classes.Implementations;

namespace FoxAndHounds
{
    public partial class MainMenu : Form
    {
        public HelpScreen helpScreen;
        public ConnectScreen connectScreen;
        public MainScreen mainScreen;
        public ChoosePlayer choosePlayer;
        public NetworkClient networkClient;

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
            choosePlayer = new ChoosePlayer();
            if (choosePlayer.ShowDialog() == DialogResult.Yes)
            {
                mainScreen = new MainScreen(new PcGame(Player.Fox));
            }
            else
            {
                mainScreen = new MainScreen(new PcGame(Player.Hounds));
            }
            mainScreen.FormClosed += OnFormsClosed;
            mainScreen.Show();
            this.Hide();
        }

        private void btnPvpLocal_Click(object sender, EventArgs e)
        {
            mainScreen = new MainScreen(new PvpLocal());
            mainScreen.FormClosed += OnFormsClosed;
            mainScreen.Show();
            this.Hide();
        }

        private void btnPvpLan_Click(object sender, EventArgs e)
        {
            networkClient = new NetworkClient();
            connectScreen = new ConnectScreen(networkClient);
            connectScreen.FormClosed += OnFormsClosed;
            connectScreen.Show();
            connectScreen.networkClient.OnGameStarted += this.OnGameStarted;
            this.Hide();
        }

        public void OnFormsClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public void OnGameStarted()
        {
            mainScreen = new MainScreen(new LanGame());
            networkClient.OnDataRead += mainScreen.game.Referee.OnDataRead;
            mainScreen.game.Referee.OnDataSent += networkClient.OnDataSent;
            mainScreen.FormClosed += OnFormsClosed;
            connectScreen.Hide();
            mainScreen.Show();
            this.Hide();
        }
    }
}
