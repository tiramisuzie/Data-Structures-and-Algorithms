using Graphs;
using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace GetEdges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trip Itinerary");
            Console.WriteLine("I want to go from Seattle to Japan to Hong Kong");
            Console.WriteLine("Seattle to Japan takes 4,812 miles and Japan to Hong Kong takes 2,785 miles");
            //Create itinerary array
            var node1 = new Node("home");
            var node2 = new Node("gym");
            var node3 = new Node("work");
            Node[] Locations = { node1, node2, node3 };
            List<Node> nodes = new List<Node>()
            {
                node1,
                node2,
                node3
            };

            //Create graph
            Graph g = new Graph(nodes);

            //Add edges
            g.AddEdge(node1, node2, 4812);
            g.AddEdge(node2, node3, 2785);
            
            Console.WriteLine("Find GetEdge...");
            int result = GetEdge(g, Locations);
            
            Console.WriteLine($"Result: {result}");
        }

        public static int GetEdge(Graph g, Node[] Locations)
        {
            int totalMile = 0;

            for (int i = 0; i < Locations.Length - 1; i++)
            {
                //Get neighbors
                var neighbors = g.GetNeighbors(Locations[i]);
                
                if (neighbors.ContainsKey(Locations[i + 1]))
                {
                    totalMile += neighbors[Locations[i + 1]];
                }
                else
                {
                    return -1;
                }
            }
            return totalMile;
        }
    }
}
