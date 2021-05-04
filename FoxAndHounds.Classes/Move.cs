using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes
{
    public class Move
    {
        public Position Start { get; set; }
        public Position Destination { get; set; }
        public IPiece Piece { get; set; }
    }
}