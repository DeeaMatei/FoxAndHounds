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
        public Type AIType { get; set; }

        public Node(Type type)
        {
            Children = new List<Node>();
            AIType = type;
        }

        public Node(Move move, Layout layout, Node parent, Type aiType)
        {
            Move = move;
            Layout = layout;
            Parent = parent;
            Score = CalculateScore(aiType);
            Children = new List<Node>();
            AIType = aiType;
        }

        public int CalculateScore(Type aiType)
        {
            if (aiType.Equals(typeof(FoxComputer)))
            {
                if (Move.Piece.GetType().Equals(typeof(Fox)))
                {
                    int moveScore = 0;
                    foreach (var piece in Layout.Arrangement)
                    {
                        if (piece.Value.GetType().Equals(typeof(Hound)))
                        {
                            if (piece.Key.Y >= Move.Destination.Y)
                            {
                                moveScore += 20;
                            }
                        }
                    }
                    moveScore += (8-Move.Destination.Y)*5;
                    return moveScore;
                }
                else
                {
                    int sum = 0;
                    foreach (var piece in Layout.Arrangement)
                    {
                        if (piece.Value.GetType().Equals(typeof(Hound)))
                        {
                            if (Move.Destination.Y == piece.Key.Y)
                            {
                                sum -= 20;
                            }
                            sum -= piece.Key.Y;
                        }
                    }
                    return sum;
                }
            }
            else
            {
                if (Move.Piece.GetType().Equals(typeof(Fox)))
                {
                    int moveScore = 0;
                    foreach (var piece in Layout.Arrangement)
                    {
                        if (piece.Value.GetType().Equals(typeof(Hound)))
                        {
                            if (piece.Key.Y == Move.Destination.Y)
                            {
                                moveScore -= 20;
                            }
                        }
                    }
                    moveScore -= (8 - Move.Destination.Y) * 5;
                    return moveScore;
                }
                else
                {
                    int sum = 0;
                    foreach (var piece in Layout.Arrangement)
                    {
                        if (piece.Value.GetType().Equals(typeof(Hound)))
                        {
                            if (Move.Destination.Y == piece.Key.Y)
                            {
                                sum += 20;
                            }
                        }
                    }
                    return sum;
                }
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
                        Node child = new Node(newMove, newLayout, this, AIType);
                        Children.Add(child);
                    }
                }
            }
        }
    }
}