using FoxAndHound.Classes.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace FoxAndHound.Classes.Implementations
{
    public class Hound : IPiece
    {
        public List<Position> GetAvailableMoves(Position currentPosition, Layout currentLayout)
        {
            List<Position> availableMoves = new List<Position>();
            if (currentPosition.Y < 7)
            {
                Position availablePosition = new Position(currentPosition.X - 1, currentPosition.Y + 1);
                if (currentPosition.X - 1 >= 0 && !currentLayout.Arrangement.ContainsKey(availablePosition))
                {
                    availableMoves.Add(availablePosition);
                }
                availablePosition = new Position(currentPosition.X + 1, currentPosition.Y + 1);
                if (currentPosition.X + 1 <= 7 && !currentLayout.Arrangement.ContainsKey(availablePosition))
                {
                    availableMoves.Add(availablePosition);
                }
            }

            return availableMoves;
        }

        public Bitmap GetImage()
        {
            Bitmap bitmap = new Bitmap(Resources.wolf);
            return bitmap;
        }
    }
}