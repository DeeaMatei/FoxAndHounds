using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class Board : Panel, IBoard
    {
        public int SquareSize { get; set; }
        public Layout BoardLayout { get; set; }
        public List<Position> AvailableMoves { get; set; }
        Layout IBoard.Layout { get; set; }

        public event MoveProposed OnMoveProposed;
        public Board()
        {

        }

        protected override void OnClick(EventArgs eventArgs)
        {

        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {

        }

        public void DrawSquares (Graphics graphics)
        {

        }

        public void DrawPieces (Graphics graphics)
        {

        }

        public void DrawAvailableMoves (Graphics graphics)
        {

        }
    }
}
