using FoxAndHound.Classes;
using FoxAndHound.Classes.Implementations;
using System.Drawing;
using System.Windows.Forms;

namespace FoxAndHounds
{
    public partial class MainScreen : Form
    {
        private Board board;
        private PvpLocal game;

        public MainScreen()
        {
            InitializeComponent();
            board = new Board();
            board.Location = new Point(40, 15);
            this.Controls.Add(board);
            game = new PvpLocal(board);
            game.Referee.OnTurnChange += this.OnTurnChange;
            game.Initialize();
            game.Start();
            this.DoubleBuffered = true;
        }

        public void OnTurnChange(Player currentMovingPlayer)
        {
            labelCurrentPlayer.Text = currentMovingPlayer.ToString() + "'s turn";
        }
    }
}