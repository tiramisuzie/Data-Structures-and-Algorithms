﻿using BreadthFirstTraversal;
using BreadthFirstTraversal.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinaryTree tree = new BinaryTree(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Left.Right.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right.Left = new Node(4);

            List<int> result = Program.BreadthFirst(tree);

            Assert.Equal(2, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(5, result[2]);
            Assert.Equal(2, result[3]);
            Assert.Equal(6, result[4]);
            Assert.Equal(9, result[5]);
            Assert.Equal(5, result[6]);
            Assert.Equal(11, result[7]);
            Assert.Equal(4, result[8]);
        }

        [Fact]
        public void Test2()
        {
            BinaryTree tree = new BinaryTree(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(9);

            List<int> result = Program.BreadthFirst(tree);

            Assert.Equal(2, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(5, result[2]);
            Assert.Equal(2, result[3]);
            Assert.Equal(6, result[4]);
            Assert.Equal(9, result[5]);
        }

        [Fact]
        public void Test3()
        {
            BinaryTree tree = new BinaryTree(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);

            List<int> result = Program.BreadthFirst(tree);

            Assert.Equal(2, result[0]);
            Assert.Equal(7, result[1]);
            Assert.Equal(5, result[2]);
        }
    }
}
