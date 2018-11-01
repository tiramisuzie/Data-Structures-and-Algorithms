using BreadthFirstTraversal.Classes;
using System;
using System.Collections.Generic;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Binary Tree");
            BinaryTree tree = new BinaryTree(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Left.Right.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right.Left = new Node(4);

            Console.WriteLine("Breadth-First Search:");
            BreadthFirst(tree);
        }

        /// <summary>
        /// Breadth-First traversal of a binary tree; print every visited node’s value
        /// </summary>
        /// <param name="tree">The binary tree to be traversed</param>
        static void BreadthFirst(BinaryTree tree)
        {
            Queue<Node> q = new Queue<Node>();

            // Return if empty
            if (tree.Root == null) return;

            q.Enqueue(tree.Root);

            while (q.Count > 0)
            {
                Node currentNode = q.Peek();
                Console.WriteLine(currentNode.Value);

                if (currentNode.Left != null)
                {
                    q.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    q.Enqueue(currentNode.Right);
                }

                // clean up
                q.Dequeue();
            }
        }
    }
}
