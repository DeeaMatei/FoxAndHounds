using System;
using FoxAndHound.Classes.Interfaces;

namespace FoxAndHound.Classes.Implementations
{
    public class FoxComputer : IComputer
    {
        public void OnComputerMove(Layout layout)
        {
            Move move = new Move();

            move = GetNextMove(layout);

            layout.MovePiece(move);
        }

        private Move GetNextMove(Layout layout)
        {
            Tree tree = new Tree(8, layout, typeof(Fox), typeof(FoxComputer));
            int bestValue = miniMax(tree.Groot, 8, true);
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