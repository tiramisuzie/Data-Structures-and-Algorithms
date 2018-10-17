using LinkedLists;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturn0IfNodeIsNull()
        {
            var result = Program.KthFromEnd(null, 2);
            Assert.Equal(0, result);
        }
        [Fact]
        public void ShouldReturnCorrectNode()
        {
            Node n = new Node();
            n.Value = 5;
            Node n2 = new Node();
            n.Next = n2;
            n2.Value = 55;
            var result = Program.KthFromEnd(n, 2);
            Assert.Equal(55, result);
        }

        [Fact]
        public void ShouldReturn0WhenKthNodeNotExist()
        {
            Node n = new Node();
            n.Value = 5;
            Node n2 = new Node();
            n.Next = n2;
            n2.Value = 55;
            var result = Program.KthFromEnd(n, 3);
            Assert.Equal(0, result);
        }
    }
}
