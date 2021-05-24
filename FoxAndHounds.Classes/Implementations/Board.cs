using FoxAndHound.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FoxAndHound.Classes.Implementations
{
    public class Board : Panel, IBoard
    {
        public int SquareSize { get; set; }
        public Layout BoardLayout { get; set; }
        public List<Position> AvailableMoves { get; set; }
        public Move PendingMove { get; set; }
        public Player CurrentMovingPlayer { get; set; }

        public event MoveProposed OnMoveProposed;

        public Board()
        {
            this.Height = 640;
            this.Width = 640;
            SquareSize = 80;
            this.DoubleBuffered = true;
        }

        protected override void OnClick(EventArgs eventArgs)
        {
            Redraw();
            Point point = PointToClient(MousePosition);
            Position position = new Position(point.X / SquareSize, point.Y / SquareSize);
            if (BoardLayout.Arrangement.ContainsKey(position))
            {
                PendingMove = new Move();
                PendingMove.Start = position;
                PendingMove.Piece = BoardLayout.Arrangement[position];
                if ((PendingMove.Piece.GetType().Equals(typeof(Hound)) && CurrentMovingPlayer == Player.Hounds) || (PendingMove.Piece.GetType().Equals(typeof(Fox)) && CurrentMovingPlayer == Player.Fox))
                {
                    DrawAvailableMoves(this.CreateGraphics(), PendingMove.Piece.GetAvailableMoves(position, BoardLayout));
                }
            }
            else
            {
                if (PendingMove != null)
                {
                    if (PendingMove.Start != null)
                    {
                        PendingMove.Destination = position;
                        MoveProposedEventArgs moveProposedEventArgs = new MoveProposedEventArgs();
                        moveProposedEventArgs.Move = PendingMove;
                        OnMoveProposed?.Invoke(this, moveProposedEventArgs);
                        PendingMove = null;
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            DrawSquares(paintEventArgs.Graphics);
            DrawPieces(paintEventArgs.Graphics);
        }

        public void DrawSquares(Graphics graphics)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var brush = (i + j) % 2 == 0 ? Brushes.DarkOliveGreen: Brushes.Black;

                    graphics.FillRectangle(brush, i * SquareSize, j * SquareSize, SquareSize, SquareSize);
                }
            }
        }

        public void DrawPieces(Graphics graphics)
        {
            foreach (var piece in BoardLayout.Arrangement)
            {
                graphics.DrawImage(piece.Value.GetImage(), piece.Key.X * SquareSize, piece.Key.Y * SquareSize, SquareSize, SquareSize);
            }
        }

        public void DrawAvailableMoves(Graphics graphics, List<Position> availablePositions)
        {
            foreach (var position in availablePositions)
            {
                graphics.DrawRectangle(new Pen(Color.Red, 3), position.X * SquareSize, position.Y * SquareSize, SquareSize, SquareSize);
            }
        }

        public void Redraw()
        {
            this.Refresh();
        }
    }
}