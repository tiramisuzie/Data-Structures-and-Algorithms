using System;

namespace multiBracketValidation.Classes
{
    public class Stack
    {
        public int size { get; set; }
        Node head;

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
            size++;
        }

        public Node Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            Node temp = head;
            head = head.Next;
            size--;
            return temp;
        }
    }
}
