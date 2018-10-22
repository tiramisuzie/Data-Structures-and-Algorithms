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
    }
}
