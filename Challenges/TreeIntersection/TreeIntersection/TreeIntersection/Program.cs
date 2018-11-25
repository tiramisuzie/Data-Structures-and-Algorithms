using System;
using System.Collections;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(3);
            Node n2 = new Node(28);
            Node n3 = new Node(-20);
            Node n4 = new Node(36);

            Node n5 = new Node(77);
            Node n6 = new Node(12);
            Node n7 = new Node(28);
            Node n8 = new Node(36);

            n1.Left = n2;
            n1.Right = n3;
            n2.Left = n4;

            n5.Left = n6;
            n6.Right = n7;
            n6.Left = n8;

            BinaryTree bt1 = new BinaryTree(n1.Value);
            BinaryTree bt2 = new BinaryTree(n5.Value);

            Console.WriteLine("same values: ");

            foreach (var item in IntersectedTree(bt1, bt2))
            {
                Console.WriteLine(item);
            }

        }

        public static List<int> IntersectedTree (BinaryTree bt1, BinaryTree bt2)
        {
            List<int> output = new List<int>();
            List<int> bt1values = new List<int>();
            List<int> bt2values = new List<int>();
            Hashtable hashTable = new Hashtable();

            foreach (var item in bt1.PreOrder(bt1.Root, bt1values))
            {
                hashTable.Add(item, item);
            }


            foreach (var item in bt2.PreOrder(bt2.Root, bt2values))
            {
                if (hashTable.Contains(item))
                {
                    output.Add(item);
                }
            }
            return output;
        }
    }
}
