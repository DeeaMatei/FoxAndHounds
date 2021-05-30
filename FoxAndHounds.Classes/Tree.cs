using System;
using FoxAndHound.Classes.Implementations;

namespace FoxAndHound.Classes
{
    public class Tree
    {
        public Node Groot { get; set; }

        public Tree(int depth, Layout layout, Type type, Type aiType)
        {
            Groot = new Node(aiType);
            Groot.Layout = layout.Clone();
            Groot.Move = new Move();
            PopulateTree(Groot, type, depth);
        }

        public void PopulateTree(Node node, Type type, int depth)
        {
            if (node != null)
            {
                if (depth > 0)
                {
                    node.AddChildren(type);
                    foreach (var child in node.Children)
                    {
                        if (type == typeof(Fox))
                        {
                            PopulateTree(child, typeof(Hound), depth-1);
                        }
                        else
                        {
                            PopulateTree(child, typeof(Fox), depth-1);
                        }
                    }
                }
                else
                {
                    return;
                }

            }
        }
    }
}