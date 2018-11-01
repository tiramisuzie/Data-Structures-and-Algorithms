
namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// Inserts a new node into a BST
        /// </summary>
        /// <param name="root">The BST's root</param>
        /// <param name="value">Value to be inserted</param>
        public Node Add(Node root, int value)
        {
            // Base case, stop when at the leaf of the tree
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            // If not empty, compare new value to root
            if (value < root.Value)
            {
                root.Left = Add(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = Add(root.Right, value);
            }

            return root;
        }

        /// <summary>
        /// Searches the tree for a value and returns the node.
        /// </summary>
        /// <param name="root">root</param>
        /// <param name="value">Value</param>
        /// <returns>if found return node, else null</returns>
        public Node Search(Node root, int value)
        {
            //Base case, stop when at the leaf of the tree
            if (root == null || root.Value == value)
            {
                return root;
            }

            // If not empty, compare new value to root
            if (value < root.Value)
            {
                return Search(root.Left, value);
            }

            return Search(root.Right, value);
        }
    }
}
