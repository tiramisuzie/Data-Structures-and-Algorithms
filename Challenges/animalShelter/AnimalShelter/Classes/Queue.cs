using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class Queue
    {
        private Node head;
        private Node tail;
        public void Enqueue(Animal animal)
        {
            if (animal != null)
            {
                if (head == null)
                {
                    head = new Node(animal);
                    tail = head;
                }
                else
                {
                    tail.Next = new Node(animal);
                    tail = tail.Next;
                }
            }
        }

        public Node Dequeue(string Pref)
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            if (Pref != "dog" && Pref != "cat")
            {
                throw new InvalidOperationException();
            }

            if (Pref != null)
            {
                Node prev = null;
                Node curr = head;
                while(curr != null)
                {
                    if (((Animal) curr.Value).type.Equals(Pref))
                    {
                        Node temp = curr;
                        if (prev != null)
                        {
                            prev.Next = curr.Next;
                        }
                        else
                        {
                            head = head.Next;
                        }
                        return temp;
                    }
                    prev = curr;
                    curr = curr.Next;
                }
                return null;
            }
            else
            {
                Node temp = head;
                head = head.Next;
                return temp;
            }
            
        }
    }
}
