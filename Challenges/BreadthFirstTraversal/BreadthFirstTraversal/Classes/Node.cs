using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class Node
    {
        /// <summary>

        /// the value contained in the node

        /// </summary>

        public int Value { get; set; }

        /// <summary>

        /// the pointer to the Left node

        /// </summary>

        public Node Left { get; set; }

        /// <summary>

        /// the pointer to the Right node

        /// </summary>
        public Node Right { get; set; }


        /// <summary>

        /// constructor for our nodes

        /// </summary>

        /// <param name="value">the value contained in the node</param>

        public Node(int value)

        {
            Value = value;
            Left = Right = null;
        }
    }
}