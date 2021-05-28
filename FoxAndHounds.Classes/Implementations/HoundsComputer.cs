using System;
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
                    move = GetNextMove(position.Key, layout);
                }
            }
            layout.MovePiece(move);
        }
        private Move GetNextMove(Position key, Layout layout)
        {
            Tree tree = new Tree(6, layout, typeof(Hound));
            int bestValue = miniMax(tree.Groot, 6, true);
            Move bestMove = new Move();
            foreach (var child in tree.Groot.Children)
            {
                if (child.Score == bestValue)
                {
                    bestMove = child.Move;
                }
            }
            return bestMove;
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