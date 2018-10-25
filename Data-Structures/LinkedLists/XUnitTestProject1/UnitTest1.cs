using LinkedLists.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddToHead()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(2));
            Assert.Equal(2, llist.Head.Value);
        }

        [Fact]
        public void ShouldAppendNodeWhenAdd()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(2));
            Assert.Equal(1, llist.Head.Next.Value);
        }

        [Fact]
        public void ShouldSetCurrentNodeToHeadWhenAdd()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(2));
            Assert.Equal(2, llist.Current.Value);
        }

        [Fact]
        public void ShouldAppendToEndOfList()
        {
            LList llist = new LList(new Node(1));
            llist.Append(new Node(2));
            Assert.Equal(1, llist.Head.Value);
        }

        [Fact]
        public void ShouldHeadNextWillPointToNewNode()
        {
            LList llist = new LList(new Node(1));
            llist.Append(new Node(2));
            Assert.Equal(2, llist.Head.Next.Value);
        }

        [Fact]
        public void ShouldHeadNextWillPointToNewNode2()
        {
            LList llist = new LList(new Node(1));
            llist.Append(new Node(2));
            llist.Append(new Node(3));
            Assert.Equal(3, llist.Head.Next.Next.Value);
        }

        [Fact]
        public void ShouldAddBeforeNode()
        {
            LList llist = new LList(new Node(1));
            llist.AddBefore(new Node(2), llist.Head);
            Assert.Equal(2, llist.Head.Value);
        }

        [Fact]
        public void ShouldAddBeforeNode2()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(3));
            llist.AddBefore(new Node(2), llist.Head.Next );
            Assert.Equal(3, llist.Head.Value);
            Assert.Equal(2, llist.Head.Next.Value);
            Assert.Equal(1, llist.Head.Next.Next.Value);
        }

        [Fact]
        public void ShouldAddBeforeNode3()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(3));
            llist.Add(new Node(4));
            llist.AddBefore(new Node(2), llist.Head.Next);
            Assert.Equal(4, llist.Head.Value);
            Assert.Equal(2, llist.Head.Next.Value);
            Assert.Equal(3, llist.Head.Next.Next.Value);
            Assert.Equal(1, llist.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void ShouldAddAfterNode()
        {
            LList llist = new LList(new Node(1));
            llist.AddAfter(new Node(2), llist.Head);
            Assert.Equal(1, llist.Head.Value);
        }

        [Fact]
        public void ShouldAddAfterNode2()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(3));
            llist.AddAfter(new Node(2), llist.Head);
            Assert.Equal(3, llist.Head.Value);
            Assert.Equal(2, llist.Head.Next.Value);
            Assert.Equal(1, llist.Head.Next.Next.Value);
        }

        [Fact]
        public void ShouldAddAfterNode3()
        {
            LList llist = new LList(new Node(1));
            llist.Add(new Node(3));
            llist.Add(new Node(4));
            llist.AddAfter(new Node(2), llist.Head);
            Assert.Equal(4, llist.Head.Value);
            Assert.Equal(2, llist.Head.Next.Value);
            Assert.Equal(3, llist.Head.Next.Next.Value);
            Assert.Equal(1, llist.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void ShouldFindNode1()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            LList lList = new LList(n1);
            lList.Add(n2);
            lList.Add(n3);
            lList.Add(n4);
            Assert.Equal(n1, lList.Find(n1));
        }

        [Fact]
        public void ShouldFindNode2()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            LList lList = new LList(n1);
            lList.Add(n2);
            lList.Add(n3);
            lList.Add(n4);
            Assert.Equal(n2, lList.Find(n2));
        }

        [Fact]
        public void ShouldFindNode3()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            LList lList = new LList(n1);
            lList.Add(n2);
            lList.Add(n3);
            lList.Add(n4);
            Assert.Equal(n4, lList.Find(n4));
        }
    }
}
