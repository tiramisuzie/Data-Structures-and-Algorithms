﻿namespace QueueWithStacks.Classes
{
    public class Node
    {
        /// <summary>

        /// the value contained in the node

        /// </summary>

        public object Value { get; set; }

        /// <summary>

        /// the pointer to the next node

        /// </summary>

        public Node Next { get; set; }
        public object Current { get; private set; }



        /// <summary>

        /// constructor for our nodes

        /// </summary>

        /// <param name="value">the value contained in the node</param>

        public Node(object value)

        {

            Value = value;

        }
    }
}
