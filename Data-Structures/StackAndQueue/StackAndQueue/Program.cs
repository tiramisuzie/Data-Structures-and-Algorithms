using StackAndQueue.Classes;
using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));
            Console.WriteLine("Peek: " + stack.Peek().Value);
            Console.WriteLine("Pop: " + stack.Pop().Value);
            Console.WriteLine("Peek: " + stack.Peek().Value);
            Console.WriteLine("Pop: " + stack.Pop().Value);
            Console.WriteLine("Peek: " + stack.Peek().Value);
            Console.WriteLine("Pop: " + stack.Pop().Value);
            Console.WriteLine("*********************************");
            Queue queue = new Queue();
            queue.Enqueue(new Node(1));
            queue.Enqueue(new Node(2));
            queue.Enqueue(new Node(3));
            Console.WriteLine("Peek: " + queue.Peek().Value);
            Console.WriteLine("Dequeue: " + queue.Dequeue().Value);
            Console.WriteLine("Peek: " + queue.Peek().Value);
            Console.WriteLine("Dequeue: " + queue.Dequeue().Value);
            Console.WriteLine("Peek: " + queue.Peek().Value);
            Console.WriteLine("Dequeue: " + queue.Dequeue().Value);
        }
    }
}
