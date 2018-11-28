using Graphs;
using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        //Test AddEdge()
        [Theory]
        [InlineData("wow", "yeah", 10)]
        [InlineData("wow", "what", 2)]
        [InlineData("what", "yeah", 5)]
        public void TestAddEdge(object v1, object v2, int weight)
        {
            List<object> words = new List<object>()
            {
                "wow",
                "yeah",
                "what"
            };
            //Set up the graph
            Graph g = new Graph(words);

            //Add edge
            g.AddEdge(v1, v2, weight);

            //Assert success - that v1 is in the adjacency list of v2 and vice versa
            Dictionary<Node, int> v1Neighbors = g.GetNeighbors(v1);
            Dictionary<Node, int> v2Neighbors = g.GetNeighbors(v2);
            Assert.True(v1Neighbors.ContainsValue(weight) && v2Neighbors.ContainsValue(weight));
        }

        //Test GetNeighbors()
        [Theory]
        [InlineData(5, 1)]
        [InlineData(-4, 10)]
        [InlineData(100, -1)]
        public void TestGetNeighbors(int weight1, int weight2)
        {
            List<object> dogs = new List<object>()
            {
                "Bean",
                "Gumiho",
                "Yogi"
            };

            //Set up the graph
            Graph g = new Graph(dogs);

            //Add edge
            g.AddEdge(dogs[0], dogs[1], weight1);
            g.AddEdge(dogs[2], dogs[0], weight2);

            Dictionary<Node, int> seattleNeighbors = g.GetNeighbors("Bean");
            Assert.True(seattleNeighbors.ContainsValue(weight1) && seattleNeighbors.ContainsValue(weight2));
        }


        //Test GetNodes
        [Theory]
        [InlineData("you", "are", "here")]
        [InlineData("where", "are", "you")]
        [InlineData("I", "Want", "Cake")]
        public void TestGetNodes(string c1, string c2, string c3)
        {
            List<object> stuff = new List<object>();
            stuff.Add(c1);
            stuff.Add(c2);
            stuff.Add(c3);
            Graph g = new Graph(stuff);
            List<Node> nodes = g.GetNodes();

            Assert.True(stuff[0] == nodes[0].Value && stuff[1] == nodes[1].Value && stuff[2] == nodes[2].Value);
        }

        //Test Size
        [Fact]
        public void ShouldReturnZeroWhenGraphIsEmpty()
        {
            List<object> thing = new List<object>();
            Graph g = new Graph(thing);
            Assert.Equal(0, g.Size());
        }

        [Fact]
        public void ShouldReturn1WhenOneNodeIsCreated()
        {
            List<object> stuff = new List<object>();
            stuff.Add("wow");
            Graph g = new Graph(stuff);
            Assert.Equal(1, g.Size());
        }

        [Fact]
        public void ShouldReturn2WhenTwoItemAreInTheGraph()
        {
            List<object> thing = new List<object>();
            thing.Add("Your so Annoying");
            thing.Add("Gumiho");
            Graph g = new Graph(thing);
            Assert.Equal(2, g.Size());
        }
    }
}
