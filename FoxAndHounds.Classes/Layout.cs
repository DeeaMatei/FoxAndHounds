using FoxAndHound.Classes.Implementations;
using FoxAndHound.Classes.Interfaces;
using System.Collections.Generic;

namespace FoxAndHound.Classes
{
    public class Layout
    {
        public Dictionary<Position, IPiece> Arrangement { get; set; }

        public Layout()
        {
            Arrangement = new Dictionary<Position, IPiece>();
        }

        public void MovePiece(Move move)
        {
            if (move.Piece == null)
            {
                move.Piece = Arrangement[move.Start];
            }
            Arrangement.Remove(move.Start);
            Arrangement.Add(move.Destination, move.Piece);
        }

        public void Initialize()
        {
            Arrangement.Add(new Position(4, 7), new Fox());
            Arrangement.Add(new Position(1, 0), new Hound());
            Arrangement.Add(new Position(3, 0), new Hound());
            Arrangement.Add(new Position(5, 0), new Hound());
            Arrangement.Add(new Position(7, 0), new Hound());
        }
    }
}