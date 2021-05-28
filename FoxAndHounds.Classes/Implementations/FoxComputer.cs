using System;
using System.Windows.Forms;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class FoxComputer : IComputer
    {
        public void OnComputerMove(Layout layout)
        {
            Move move = new Move();
            foreach (var position in layout.Arrangement)
            {
                if (position.Value.GetType().Equals(typeof(Fox)) && (position.Value.GetAvailableMoves(position.Key, layout).Count != 0)){
                    move.Start = position.Key;
                    move.Piece = position.Value;
                    move.Destination = GetNextMove(position.Key, layout);
                }
            }
            layout.MovePiece(move);
        }

        private Position GetNextMove(Position key, Layout layout)
        {
            Tree tree = new Tree(6, layout, typeof(Fox));
            int bestValue = miniMax(tree.Groot, 6, true);
            Position bestPosition = new Position(7, 7);
            foreach (var child in tree.Groot.Children)
            {
                if (child.Score == bestValue)
                {
                    bestPosition = child.Move.Destination;
                }
            }
            return bestPosition;
        }

        private int miniMax(Node node, int depth, bool maxPlayer)
        {
            if (depth == 0 || node.Children.Count == 0)
            {
                return node.Score;
            }
            int value;
            if (maxPlayer)
            {
                value = -1000;
                foreach (var child in node.Children)
                {
                    value = Math.Max(value, miniMax(child, depth - 1, false));
                }
                node.Score = value;
                return value;
            }
            else
            {
                value = 1000;
                foreach (var child in node.Children)
                {
                    value = Math.Min(value, miniMax(child, depth - 1, true));
                }
                node.Score = value;
                return value;
            }
        }
    }
}
