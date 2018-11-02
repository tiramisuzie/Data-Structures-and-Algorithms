using Tree.Classes;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Test Preorder
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestPreorder(int v1, int v2, int v3)
        {
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            List<int> expected = new List<int> { v1, v2, v3 };
            List<int> result = new List<int>();

            t.PreOrder(t.Root, result);

            Assert.Equal(expected, result);
        }

        // Test Inorder
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestInorder(int v1, int v2, int v3)
        {
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            List<int> result = new List<int>();
            List<int> expected = new List<int> { v2, v1, v3 };
            
            t.InOrder(t.Root, result);

            Assert.Equal(expected, result);
        }

        // Test Postorder
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestPostorder(int v1, int v2, int v3)
        {
            BinaryTree t = new BinaryTree(v1);
            t.Root.Left = new Node(v2);
            t.Root.Right = new Node(v3);
            List<int> result = new List<int>();
            List<int> expected = new List<int> { v2, v3, v1 };
            
            t.PostOrder(t.Root, result);

            Assert.Equal(expected, result);
        }
    }
}
