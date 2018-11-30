using System.Collections.Generic;

namespace Graphs.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Dictionary<Node, int> AdjacentNodes { get; set; } // bridge between nodes

        public Node(object value)
        {
            Value = value;
            AdjacentNodes = new Dictionary<Node, int>();
        }
    }
}
