using Tree.Classes;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest2
    {
        //Test add a value
        [Fact]
        public void ShouldAddValue()
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Root = bst.Add(bst.Root, 1);

            Assert.Equal(1, bst.Root.Value);
        }

        //Test BST add two values
        [Fact]
        public void ShouldAdd2Values()
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 2);

            Assert.True(bst.Root.Value == 1 && bst.Root.Right.Value == 2);
        }

        //Test add three values where one is the same
        [Fact]
        public void ShouldAdd3Values()
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 1);
            bst.Root = bst.Add(bst.Root, 2);

            Assert.True(bst.Root.Value == 1 && bst.Root.Right.Value == 2 && bst.Root.Left == null);
        }

        //Test Search exists
        [Fact]
        public void ShouldFindExistingValue()
        {
            int[] values = { 6, 28, 92, 88, 10 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }

            Node result = bst.Search(bst.Root, 6);

            Assert.Equal(6, result.Value);
        }
        
        [Fact]
        public void ShouldFindExistingValue2()
        {
            int[] values = { 10 };
            BinarySearchTree bst = new BinarySearchTree();

            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }

            Node result = bst.Search(bst.Root, 10);

            Assert.Equal(10, result.Value);
        }
        
        [Fact]
        public void ShouldNotFindExistingValue()
        {
            int[] values = { 6, 28, 92, 88, 10 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int num in values)
            {
                bst.Root = bst.Add(bst.Root, num);
            }

            Node result = bst.Search(bst.Root, 5);

            Assert.Null(result);
        }
    }
}
