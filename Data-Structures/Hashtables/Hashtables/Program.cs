using System;
using System.Collections.Generic;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a hashtable");

            // Hashtable with size of 5
            Hashtable ht = new Hashtable(5);

            // Add items to your hashtable
            Console.WriteLine("Adding stuff in hashtable...");
            Console.WriteLine("Adding the key 'hello' with the value 'world'.");
            ht.Add("hello", "world");
            Console.WriteLine("Adding the key 'hey' with the value 'yo'.");
            ht.Add("hey", "yo");
            Console.WriteLine("Adding the key 'foo' with the value 'bar'.");
            ht.Add("foo", "bar");
            Console.WriteLine("Adding the key 'roar' with the value 'rawr'.");
            ht.Add("roar", "rawr");
            Console.WriteLine();

            //Prove that all keys added exist in the hashtable.
            List<string> keys = new List<string>();
            keys.Add("hello");
            keys.Add("foo");
            keys.Add("roar");
            keys.Add("hey");

            Console.WriteLine("Proving that each key exists in the hashtable...");
            foreach (string word in keys)
            {
                Console.WriteLine($"{word}:{ht.Find(word)}");
            }
        }
    }
}
