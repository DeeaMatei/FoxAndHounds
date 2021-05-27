using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class HoundsComputer : IComputer
    {
        public void OnComputerMove(Layout layout)
        {
            Move move = new Move();
            foreach (var position in layout.Arrangement)
            {
                if (position.Value.GetType().Equals(typeof(Hound)) && (position.Value.GetAvailableMoves(position.Key, layout).Count != 0))
                {
                    move.Start = position.Key;
                    move.Piece = position.Value;
                    move.Destination = GetNextMove(position.Key, layout);
                }
            }
            layout.MovePiece(move);
        }
        private Position GetNextMove(Position key, Layout layout)
        {
            Position bestDestination = layout.Arrangement[key].GetAvailableMoves(key, layout)[0];
            return bestDestination;
        }
    }
}