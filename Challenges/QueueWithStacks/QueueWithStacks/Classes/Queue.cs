using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        Stack s1;
        Stack s2;
        public Queue()
        {
            s1 = new Stack();
            s2 = new Stack();
        }

        public void Enqueue(int value)
        {
            while(s1.size > 0)
            {
                s2.Push(s1.Pop());
            }
               
            s1.Push(new Node(value));

            while(s2.size > 0)
            {
                s1.Push(s2.Pop());
            }
            
        }

        public int Dequeue()
        {
            return (int) s1.Pop().Value;
        }

    }
}
