using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            Bt();
            Console.WriteLine("");
            Bst();

        }

        public static void Bt()
        {
            Console.WriteLine("Binary Tree!");

            BinaryTree tree = new BinaryTree(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            List<int> preOrder = new List<int>();
            List<int> inOrder = new List<int>();
            List<int> postOrder = new List<int>();

            Console.WriteLine("DFS Traversal Order: ");
            Console.WriteLine("* Pre-order:");
            tree.PreOrder(tree.Root, preOrder);
            foreach (int val in preOrder)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
            Console.WriteLine("* In-order:");
            tree.InOrder(tree.Root, inOrder);
            foreach (int val in inOrder)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
            Console.WriteLine("* Post-order:");
            tree.PostOrder(tree.Root, postOrder);
            foreach (int val in postOrder)
            {
                Console.Write($"{val} ");
            }
        }

        public static void Bst()
        {
            int[] bstValues = { 1, 2, 3, 4, 5 };

            Console.WriteLine($"Creating a binary search tree with the following values: {string.Join(",", bstValues)}");
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in bstValues)
            {
                bst.Root = bst.Add(bst.Root, num);
            }
            List<int> bstInOrder = new List<int>();
            bst.InOrder(bst.Root, bstInOrder);
            Console.WriteLine("BST in-order traversal:");
            foreach (int val in bstInOrder)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine("");
            Console.WriteLine("find value 2 in tree");
            Console.WriteLine("value: " + bst.Search(bst.Root, 2).Value);
        }
    }
}
