using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTrivia
{
    public class AVLTree
    {
        public AVLTree(IEnumerable<int> inArray=null)
        {
            if (inArray.Any())
            {
                foreach (var value in inArray)
                {
                    this.Add(value);
                }
            }

        }

        public Node Root { get; set; }

        public void Add(int data)
        {
            Node newItem = new Node() { Value = data };
            if (Root == null)
            {
                Root = newItem;
            }
            else
            {
                Root = RecursiveInsert(Root, newItem);
            }
        }
        private Node RecursiveInsert(Node current, Node target)
        {
            //found our new or existing assignment 
            if (current == null || current.Value == target.Value)
            {
                current = target;
                return current;
            }
            
            //find the next open spot
            //on the left if the target is less than current
            if (target.Value < current.Value)
            {
                current.Left = RecursiveInsert(current.Left, target);
            }
            else // or on the right if target is greater than current
            {
                current.Right = RecursiveInsert(current.Right, target);
            }

            // now balance for current node
            current = BalanceTree(current);

            return current;
        }
        private Node BalanceTree(Node current)
        {
            int bFactor = BalanceFactor(current);

            //left side heavy
            if (bFactor > 1)
            {
                //rotate RR if current left heavy
                if (BalanceFactor(current.Left) > 0)
                {
                    current = RotateRR(current);
                }
                else //rotate LR
                {
                    current = RotateLR(current);
                }
            }
            else if (bFactor < -1)//right side heavy
            {
                //rotate RL if Right side has a heavy Left
                if (BalanceFactor(current.Right) > 0)
                {
                    current = RotateRL(current);
                }
                else // rotate LL 
                {
                    current = RotateLL(current);
                }
            }
            return current;
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

        public int GetHeight()
        {
            var result = 1;
            var currentNode = Root;
            while (currentNode != null)
            {
                var anyNode = currentNode.Left ?? currentNode.Right;
                currentNode = anyNode;

                if (anyNode != null)
                {
                    result++;
                }
            }
            return result;
        }

        private int GetHeight(Node current)
        {
            var height = 0;
            if (current != null)
            {
                var lHeight = GetHeight(current.Left);
                var rHeight = GetHeight(current.Right);
                var max = lHeight > rHeight ? lHeight : rHeight;
                height = max + 1;
            }
            return height;
        }

        /// <summary>
        /// Uses the Height delta of the Left & Right sides to determine how balanced the tree is.
        /// </summary>
        /// <param name="current"></param>
        /// <returns>The Delta of Left & Right side Heights. 
        /// Positive results indicate Left side heavy. Negative results indicate Right side heavy.</returns>
        private int BalanceFactor(Node current)
        {
            var lHeight = GetHeight(current.Left);
            var rHeight = GetHeight(current.Right);
            var result = lHeight - rHeight;
            return result;
        }

        private Node RotateRR(Node target)
        {
            var pivot = target.Left;
            target.Left = pivot.Right;
            pivot.Right = target;
            return pivot;
        }
                
        private Node RotateLL(Node target)
        {
            var pivot = target.Right;
            target.Right = pivot.Left;
            pivot.Left = target;
            return pivot;
        }
        
        private Node RotateRL(Node target)
        {
            var pivot = target.Right;
            target.Right = RotateRR(pivot);
            return RotateLL(target);
        }

        private Node RotateLR(Node target)
        {
            var pivot = target.Left;
            target.Left = RotateLL(pivot);
            return RotateRR(target);
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
