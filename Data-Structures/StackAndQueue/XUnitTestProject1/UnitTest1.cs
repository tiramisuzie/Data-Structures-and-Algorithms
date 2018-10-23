using StackAndQueue.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            Assert.Equal(1, stack.Peek().Value);
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            Assert.Equal(1, stack.Pop().Value);
        }

        [Fact]
        public void TestPeek()
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            stack.Push(new Node(3));
            Assert.Equal(3, stack.Peek().Value);
        }

        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Node(1));
            Assert.Equal(1, queue.Peek().Value);
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Node(1));
            Assert.Equal(1, queue.Dequeue().Value);
        }

        [Fact]
        public void TestQueuePeek()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Node(1));
            queue.Enqueue(new Node(3));
            Assert.Equal(1, queue.Peek().Value);
        }
    }
}
