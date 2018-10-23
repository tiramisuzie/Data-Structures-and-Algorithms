using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        private Node head;
        private Node tail;
        public void Enqueue(Node node)
        {
            if (node != null)
            {
                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.Next = node;
                    tail = tail.Next;
                }
            }
        }

        public Node Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            Node temp = head;
            head = head.Next;
            return temp;
        }

        public Node Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            return head;
        }
    }
}
