using System;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        private Node head;

        public void Push(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                node.Next = temp;
            }
        }

        public Node Pop()
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
