using FoxAndHound.Classes;
using FoxAndHound.Classes.Implementations;
using System.Drawing;
using System.Windows.Forms;

namespace FoxAndHounds
{
    public partial class MainScreen : Form
    {
        private Board board;
        public IGame game;

        public MainScreen(IGame game)
        {
            InitializeComponent();
            this.game = game;
            board = new Board();
            board.Location = new Point(40, 15);
            this.Controls.Add(board);
            this.game.Initialize(board);
            this.game.Referee.OnTurnChange += this.OnTurnChange;
            this.game.Start();
            this.DoubleBuffered = true;
        }

        public void OnTurnChange(Player currentMovingPlayer)
        {
            labelCurrentPlayer.Text = currentMovingPlayer.ToString() + "'s turn";
        }
    }
}