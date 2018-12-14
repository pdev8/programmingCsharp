using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC08
    {
        public static void Run()
        {

        }
        

        public bool IsBalanced(BinaryTreeNode treeRoot)
        {
            if (treeRoot == null)
            {
                return true;
            }

            List<int> depths = new List<int>(3); // We short-circuit as soon as we find more than 2

            Stack<NodeDepthPair> nodes = new Stack<NodeDepthPair>();
            nodes.Push(new NodeDepthPair(treeRoot, 0));

            while (nodes.Count > 0)
            {
                NodeDepthPair nodeDepthPair = nodes.Pop();
                BinaryTreeNode node = nodeDepthPair.Node;
                int depth = nodeDepthPair.Depth;

                if (node.Left == null && node.Right == null)
                {
                    if (!depths.Contains(depth))
                    {
                        depths.Add(depth);

                        if (depths.Count > 2 || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (node.Left != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Left, depth + 1));
                    }

                    if (node.Right != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Right, depth + 1));
                    }
                }
            }

            return true;
        }
    }

    class NodeDepthPair
    {
        public BinaryTreeNode Node { get; }

        public int Depth { get; }

        public NodeDepthPair(BinaryTreeNode node, int depth)
        {
            Node = node;
            Depth = depth;
        }
    }

    class BinaryTreeNode
    {
        public int Value { get; }

        public BinaryTreeNode Left { get; private set; }

        public BinaryTreeNode Right { get; private set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode InsertLeft(int leftValue)
        {
            Left = new BinaryTreeNode(leftValue);
            return Left;
        }

        public BinaryTreeNode InsertRight(int rightValue)
        {
            Right = new BinaryTreeNode(rightValue);
            return Right;
        }
    }
}
