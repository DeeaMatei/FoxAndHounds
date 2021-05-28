using System;
using System.Collections.Generic;
using System.Linq;
using FoxAndHound.Classes.Implementations;

namespace FoxAndHound.Classes
{
    public class Node
    {
        public int Score { get; set; }
        public Layout Layout { get; set; }
        public Move Move { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }

        public Node()
        {
            Children = new List<Node>();
        }

        public Node(Move move, Layout layout, Node parent)
        {
            Move = move;
            Layout = layout;
            Parent = parent;
            Score = CalculateScore();
            Children = new List<Node>();
        }

        public int CalculateScore()
        {
            if (Move.Piece.GetType().Equals(typeof(Fox)))
            {
                return (Move.Destination.Y+Move.Destination.X)*2;
            }
            else
            {
                int sum = 0;
                foreach (var piece in Layout.Arrangement)
                {
                    if (piece.Value.GetType().Equals(typeof(Hound)))
                    {
                        sum += piece.Key.Y;
                    }
                }
                return sum;
            }
        }

        public void AddChildren(Type type)
        {
            foreach (var piece in Layout.Arrangement.Values)
            {
                if (piece.GetType().Equals(type))
                {
                    Position initialPosition = Layout.Arrangement.FirstOrDefault(x => x.Value.Equals(piece)).Key;
                    foreach (var position in piece.GetAvailableMoves(initialPosition, Layout))
                    {
                        Move newMove = new Move();
                        newMove.Start = initialPosition;
                        newMove.Destination = position;
                        newMove.Piece = piece;
                        Layout newLayout = Layout.Clone();
                        newLayout.MovePiece(newMove);
                        Node child = new Node(newMove, newLayout, this);
                        Children.Add(child);
                    }
                }
            }
        }
    }
}