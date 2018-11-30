using Graphs.Classes;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        
        public Graph(List<Node> values)
        {
            Nodes = new List<Node>();
            foreach (Node value in values)
            {
                Nodes.Add(value); // add nodes to graph
            }
        }

        public void AddEdge(Node v1, Node v2, int weight)
        {
            Node v1Ref = Nodes.Find(x => x.Value == v1.Value);
            if (v1Ref == null)
            {
                v1Ref = v1;
                Nodes.Add(v1Ref);
            }
            Node v2Ref = Nodes.Find(x => x.Value == v2.Value);
            if (v2Ref == null)
            {
                v2Ref = v2;
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

        public Dictionary<Node, int> GetNeighbors(Node node)
        {
            Node nodeRef = Nodes.Find(x => x.Value == node.Value);

            if (nodeRef == null)
            {
                return null;
            }

            return nodeRef.AdjacentNodes; // return all nodes connected to it
        }
    }
}
