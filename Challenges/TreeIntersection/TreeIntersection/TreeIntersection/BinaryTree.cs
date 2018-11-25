using System.Collections.Generic;

namespace TreeIntersection
{
        public class BinaryTree
        {
            public Node Root { get; set; }

            public BinaryTree(Node value)
            {
                Root = value;
            }

            /// <summary>
            /// depth first traversal - root, left, right
            /// </summary>
            /// <param name="node">root node</param>
            /// <param name="output">node values in PreOrder traversal</param>
            /// <returns></returns>
            public List<int> PreOrder(Node node, List<int> output)
            {
                output.Add(node.Value);

                if (node.LeftChild != null)
                {
                    PreOrder(node.LeftChild, output);
                }
                if (node.RightChild != null)
                {
                    PreOrder(node.RightChild, output);
                }

                return output;
            }

            /// <summary>
            /// depth first traversal - left, root, right
            /// </summary>
            /// <param name="node">root node</param>
            /// <param name="output">node values InOrder traversal</param>
            /// <returns></returns>
            public List<int> InOrder(Node node, List<int> output)
            {
                if (node.LeftChild != null)
                {
                    InOrder(node.LeftChild, output);
                }

                output.Add(node.Value);

                if (node.RightChild != null)
                {
                    InOrder(node.RightChild, output);
                }

                return output;
            }

            /// <summary>
            /// depth first traversal - left, right, root
            /// </summary>
            /// <param name="node">root node</param>
            /// <param name="output">node values in PostOrder traversal</param>
            /// <returns></returns>
            public List<int> PostOrder(Node node, List<int> output)
            {
                if (node.LeftChild != null)
                {
                    PostOrder(node.LeftChild, output);
                }

                if (node.RightChild != null)
                {
                    PostOrder(node.RightChild, output);
                }

                output.Add(node.Value);
                return output;
            }
        }
    }
