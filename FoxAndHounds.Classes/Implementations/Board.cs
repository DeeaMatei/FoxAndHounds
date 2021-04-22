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
        Layout IBoard.Layout { get; set; }

        public event MoveProposed OnMoveProposed;

        public Board()
        {
            this.Height = 640;
            this.Width = 640;
            SquareSize = 80;
        }

        protected override void OnClick(EventArgs eventArgs)
        {
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
                    color1 = Color.Black;
                    color2 = Color.DarkOliveGreen;
                }
                else
                {
                    color1 = Color.DarkOliveGreen;
                    color2 = Color.Black;
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
            Hound hound = new Hound();
            Fox fox = new Fox();

            graphics.DrawImage(fox.GetImage(), 80, 0, SquareSize, SquareSize);
            graphics.DrawImage(hound.GetImage(), 160, 0, SquareSize, SquareSize);
            graphics.DrawImage(hound.GetImage(), 240, 0, SquareSize, SquareSize);
            graphics.DrawImage(hound.GetImage(), 320, 0, SquareSize, SquareSize);
            graphics.DrawImage(hound.GetImage(), 400, 0, SquareSize, SquareSize);
        }

        public void DrawAvailableMoves(Graphics graphics)
        {
        }
    }
}