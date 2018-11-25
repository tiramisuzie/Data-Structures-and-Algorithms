using System.Collections.Generic;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Default contructor
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Constructor that assign a given value to the root
        /// </summary>
        /// <param name="value">Root</param>
        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        /// <summary>
        /// Returns a list of values in pre-order for a binary tree
        /// </summary>
        /// <param name="root">root</param>
        /// <param name="valuesInPreOrder">result is added to list</param>
        public List<int> PreOrder(Node node, List<int> output)
        {
            output.Add(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, output);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right, output);
            }

            return output;
        }

        /// <summary>
        /// Returns a list of values in order for a binary tree
        /// </summary>
        /// <param name="root">root</param>
        /// <param name="valuesInOrder">result is added to list</param>
        public void InOrder(Node root, List<int> result)
        {
            //Base case: stop when height of node is reached
            if (root == null)
            {
                return;
            }

            InOrder(root.Left, result);
            result.Add(root.Value);
            InOrder(root.Right, result);
        }


        /// <summary>
        /// Returns a list of values in post-order for a binary tree
        /// </summary>
        /// <param name="root">root</param>
        /// <param name="valuesInPostOrder">result is added to list</param>
        public void PostOrder(Node root, List<int> result)
        {
            //Base case: stop when height of node is reached
            if (root == null)
            {
                return;
            }

            PostOrder(root.Left, result);
            PostOrder(root.Right, result);
            result.Add(root.Value);
        }
    }
}
