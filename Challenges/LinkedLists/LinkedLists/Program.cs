using System;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int KthFromEnd(Node head, int k)
        {
            if (head == null)
            {
                return 0;
            }

            Node current = head;
            int counter = 1;
            while (current != null)
            { 
                if (counter - k == 0)
                {
                    return current.Value;
                }
                current = current.Next;
                counter++;
            }
            
            return 0;
        }
    }
}
