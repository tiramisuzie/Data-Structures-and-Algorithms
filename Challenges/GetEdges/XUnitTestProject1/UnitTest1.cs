using GetEdges;
using Graphs;
using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //Test GetEdge only one city
        [Fact]
        public void Test1City()
        {
            var n1 = new Node("Seattle");
            List<Node> nodes = new List<Node>()
            {
                n1
            };

            Node[] cities = { n1 };

            //Create graph
            Graph g = new Graph(nodes);
            int result = Program.GetEdge(g, cities);
            Assert.Equal(0, result);
        }

        //Test path exists
        [Fact]
        public void TestPathExists()
        {
            var n1 = new Node("Seattle");
            var n2 = new Node("Japan");
            var n3 = new Node("Hong Kong");
            List<Node> nodes = new List<Node>()
            {
                n1,
                n2,
                n3
            };

            Node[] cities = { n1, n2, n3 };

            //Create graph
            Graph g = new Graph(nodes);
            g.AddEdge(n1, n2, 4812);
            g.AddEdge(n2, n3, 2700);
            int result = Program.GetEdge(g, cities);
            Assert.Equal(7512, result);
        }

        //Test path does not exist
        [Fact]
        public void TestPathDoesNotExist()
        {
            var n1 = new Node("Seattle");
            var n2 = new Node("Japan");
            var n3 = new Node("Hong Kong");
            List<Node> nodes = new List<Node>()
            {
                n1,
                n2,
                n3
            };

            Node[] cities = { n1, n2, n3 };

            //Create graph
            Graph g = new Graph(nodes);
            g.AddEdge(n1, n2, 4812);
            g.AddEdge(n1, n3, 2700);
            int result = Program.GetEdge(g, cities);
            Assert.Equal(-1, result);
        }
    }
}
