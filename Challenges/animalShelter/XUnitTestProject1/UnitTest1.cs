using AnimalShelter.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueTest1()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(new Dog());

            // Act
            Animal result = queue.Dequeue(null);

            // Assert
            Assert.Equal("dog", result.type);
        }

        [Fact]
        public void EnqueueTest2()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Cat());

            Animal result = queue.Dequeue(null);

            Assert.Equal("cat", result.type);
        }
        [Fact]
        public void EnqueueTest3()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Cat());
            queue.Enqueue(new Dog());

            Animal result = queue.Dequeue(null);
            Animal result2 = queue.Dequeue(null);

            Assert.Equal("cat", result.type);
            Assert.Equal("dog", result2.type);
        }

        [Fact]
        public void DequeueTest1()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Cat());

            Animal result = queue.Dequeue("cat");

            Assert.Equal("cat", result.type);
        }

        [Fact]
        public void DequeueTest2()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Cat());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());

            Animal result = queue.Dequeue("dog");

            Assert.Equal("dog", result.type);
        }
        [Fact]
        public void DequeueTest3()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Cat());

            Animal result = queue.Dequeue("dog");

            Assert.Null(result);
        }
    }
}
