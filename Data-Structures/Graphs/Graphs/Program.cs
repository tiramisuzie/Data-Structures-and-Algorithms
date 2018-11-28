using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graphs!");
            List<object> stuff = new List<object>();
            stuff.Add("foo");
            stuff.Add("bar");

            //Set up the graph
            Graph g = new Graph(stuff);
            Console.WriteLine(g.Size());

            Console.WriteLine("The size of your graph is: ");
            Console.WriteLine(g.Size());

            g.AddEdge("foo", "bar", 2);
            Console.WriteLine("I connected the nodes");
            Console.WriteLine();

            Console.WriteLine("Return all Nodes: ");
            var nodes = g.GetNodes();
            foreach (var item in nodes)
            {
                var otherNode = nodes.FirstOrDefault(x => x.Value != item.Value);
                Console.WriteLine((string) item.Value + ", Weight = " + item.AdjacentNodes[otherNode]);
            }
            Console.WriteLine();

            Console.WriteLine("Get neighbor Nodes: ");
            foreach (var item in g.GetNeighbors("foo"))
            {
                var otherNode = g.GetNeighbors("bar").FirstOrDefault();
                Console.WriteLine($"{item.Key.Value}, Weight = {item.Value}" );
            }
        }
        
    }
}
