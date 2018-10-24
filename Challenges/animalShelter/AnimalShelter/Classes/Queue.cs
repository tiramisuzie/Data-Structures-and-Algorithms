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

        public Animal Dequeue(string Pref)
        {
            // Invalid because queue is empty
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            // only allow null or dog or cat input
            if (Pref != "dog" && Pref != "cat" && Pref != null)
            {
                throw new InvalidOperationException();
            }

            // go with pref logic
            if (Pref != null)
            {
                Node prev = null; // previous pointer
                Node curr = head; // current pointer
                // cycle through the queue to find the pref
                while(curr != null)
                {
                    // compare pref and animal.type
                    if (((Animal) curr.Value).type.Equals(Pref))
                    {
                        Node temp = curr;
                        if (prev != null) // patch the node if removed from the middle
                        {
                            prev.Next = curr.Next;
                        }
                        else // when head is the pref
                        {
                            head = head.Next;
                        }
                        return (Animal) temp.Value; // return the animal that matches the pref
                    }
                    prev = curr;
                    curr = curr.Next;
                }
                return null; // not found
            }
            else
            {
                Node temp = head;
                head = head.Next;
                return (Animal) temp.Value; // return any animal because pref wasn't specified
            }
            
        }
    }
}
