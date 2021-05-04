using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class Board : Panel, IBoard
    {
        public int SquareSize { get; set; }
        public Layout BoardLayout { get; set; }
        public List<Position> AvailableMoves { get; set; }

        public Move Move { get; set; }

        public Player CurrentMovingPlayer { get; set; }

        public event MoveProposed OnMoveProposed;

        public Board()
        {
            this.Height = 640;
            this.Width = 640;
            SquareSize = 80;
        }

        protected override void OnClick(EventArgs eventArgs)
        {
            Redraw();
            Point point = PointToClient(MousePosition);
            Console.WriteLine(point.X/SquareSize + " " +point.Y/SquareSize);
            Position position = new Position(point.X / SquareSize, point.Y / SquareSize);
            if (BoardLayout.Arrangement.ContainsKey(position))
            {
                Move = new Move();
                Move.Start = position;
                Move.Piece = BoardLayout.Arrangement[position];
                if ((Move.Piece.GetType().Equals(typeof(Hound)) && CurrentMovingPlayer == Player.Hounds) || (Move.Piece.GetType().Equals(typeof(Fox)) && CurrentMovingPlayer == Player.Fox))
                {
                    DrawAvailableMoves(this.CreateGraphics(), Move.Piece.GetAvailableMoves(position, BoardLayout));
                }
            }
            else
            {
                if (Move != null)
                {
                    if (Move.Start != null)
                    {
                        Move.Destination = position;
                        MoveProposedEventArgs moveProposedEventArgs = new MoveProposedEventArgs();
                        moveProposedEventArgs.Move = Move;
                        OnMoveProposed?.Invoke(this, moveProposedEventArgs);
                        Move = null;
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
            Color color1, color2;
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    color2 = Color.Black;
                    color1 = Color.DarkOliveGreen;
                }
                else
                {
                    color2 = Color.DarkOliveGreen;
                    color1 = Color.Black;
                }
                SolidBrush blackBrush = new SolidBrush(color1);
                SolidBrush whiteBrush = new SolidBrush(color2);

                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0)
                        graphics.FillRectangle(blackBrush, i * SquareSize, j * SquareSize, SquareSize, SquareSize);
                    else
                        graphics.FillRectangle(whiteBrush, i * SquareSize, j * SquareSize, SquareSize, SquareSize);
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
            Color color = Color.Red;
            Pen pen = new Pen(color);
            foreach (var position in availablePositions)
            {
                graphics.DrawRectangle(pen, position.X * SquareSize, position.Y * SquareSize, SquareSize, SquareSize);
            }
        }

        public void Redraw()
        {
            this.Refresh();
        }
    }
}