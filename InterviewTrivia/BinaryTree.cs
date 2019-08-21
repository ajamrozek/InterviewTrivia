using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTrivia
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        
        public void Insert(int value)
        {
            var newNode = new Node()
            {
                Value = value
            };

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else if(value > current.Value)
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public Node Find(int value)
        {
            if(Root == null)
            {
                return null;
            }

            return Find(value, Root);
        }

        private Node Find(int value, Node seed)
        {
            if (seed.Value == value)
            {
                return seed;
            }

            if (value > seed.Value)
            {
                if(seed.Right == null)
                {
                    return null;
                }
                return Find(value, seed.Right);
            }
            else
            {
                if (seed.Left == null)
                {
                    return null;
                }
                return Find(value, seed.Left);
            }

        }


        public void ReadTree(Node current, List<string> results)
        {

            if (current != null)
            {
                ReadTree(current.Left, results);
                results.Add(current.Value.ToString());
                ReadTree(current.Right, results);
            }
        }

        public bool IsBST()
        {
            return IsBST(Root, null, null);
        }

        private bool IsBST(Node p, int? start, int? end)
        {
            if (p == null) return true;
            return (start == null || p.Value > start) &&
                   (end == null || p.Value < end) &&
                   IsBST(p.Left, start, p.Value) &&
                   IsBST(p.Right, p.Value, end);
        }
    }

    public class Node
    {
        public Node Left{ get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
