using QueueWithStacks.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldEnqueue1()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
        }

        [Fact]
        public void ShouldEnqueue2()
        {
            Queue queue = new Queue();
            queue.Enqueue(0);
            queue.Enqueue(2);
            Assert.Equal(0, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
        }

        [Fact]
        public void ShouldEnqueue3()
        {
            Queue queue = new Queue();
            queue.Enqueue(0);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
        }

        [Fact]
        public void ShouldDequeue1()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(15);
            queue.Enqueue(10);
            Assert.Equal(20, queue.Dequeue());
            Assert.Equal(15, queue.Dequeue());
            Assert.Equal(10, queue.Dequeue());
        }

        [Fact]
        public void ShouldDequeue2()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(15);
            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.Dequeue();
            Assert.Equal(15, queue.Dequeue());
        }

        [Fact]
        public void ShouldDequeue3()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(15);
            queue.Enqueue(10);
            queue.Enqueue(5);
            Assert.Equal(20, queue.Dequeue());
        }
    }
}
