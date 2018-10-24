using AnimalShelter.Classes;
using System;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(new Dog());
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));

            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            Console.WriteLine("Dequeue: " + queue.Dequeue("dog"));
            Console.WriteLine("Dequeue: " + queue.Dequeue("dog"));
            Console.WriteLine("Dequeue: " + queue.Dequeue("dog"));

            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("***********test 3**************");
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            Console.WriteLine("Dequeue: " + queue.Dequeue("dog"));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));
            Console.WriteLine("Dequeue: " + queue.Dequeue(null));


        }
    }
}
