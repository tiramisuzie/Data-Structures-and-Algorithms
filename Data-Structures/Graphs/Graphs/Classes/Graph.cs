using Graphs.Classes;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        
        public Graph(List<object> values)
        {
            Nodes = new List<Node>();
            foreach (object value in values)
            {
                Nodes.Add(new Node(value)); // add nodes to graph
            }
        }

        public void AddEdge(object v1, object v2, int weight)
        {
            Node v1Ref = Nodes.Find(x => x.Value == v1);
            if (v1Ref == null)
            {
                v1Ref = new Node(v1);
                Nodes.Add(v1Ref);
            }
            Node v2Ref = Nodes.Find(x => x.Value == v2);
            if (v2Ref == null)
            {
                v2Ref = new Node(v2);
                Nodes.Add(v2Ref);
            }
            
            v1Ref.AdjacentNodes.Add(v2Ref, weight); // create a bridge between the nodes
            v2Ref.AdjacentNodes.Add(v1Ref, weight);
        }

        public List<Node> GetNodes()
        {
            return Nodes; // return all nodes
        }

        public int Size()
        {
            return Nodes.Count; // return the size of graph
        }

        public Dictionary<Node, int> GetNeighbors(object value)
        {
            Node nodeRef = Nodes.Find(x => x.Value == value);

            if (nodeRef == null)
            {
                return null;
            }

            return nodeRef.AdjacentNodes; // return all nodes connected to it
        }
    }
}
