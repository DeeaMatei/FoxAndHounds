using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxAndHound.Classes;
using FoxAndHound.Classes.Implementations;

namespace FoxAndHounds
{
    public partial class MainScreen : Form
    {
        Board board;
        PvpLocal game;

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

        public void OnTurnChange (Player currentMovingPlayer)
        {
            labelCurrentPlayer.Text = currentMovingPlayer.ToString() + "'s turn";
        }
    }
}
