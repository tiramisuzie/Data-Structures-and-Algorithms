using Hashtables.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        public Node[] Table { get; set; }

        public int Count { get; set; }

        public int Size { get; set; }

        public Hashtable(int size)
        {
            Size = size;
            Table = new Node[Size];
            for (int i = 0; i < Size; i++)
            {
                Table[i] = null;
            }
        }

        public void Add(string key, object value)
        {
            if (!checkOpenSpace())//if no open spaces available
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }
            int hash = (Math.Abs(key.GetHashCode()) % Size);
            Console.WriteLine(hash);
            while (Table[hash] != null && Table[hash].Key != key)
            {
                hash = (hash + 1) % Size;
            }
            Table[hash] = new Node(key, value);
        }

        private bool checkOpenSpace()//checks for open spaces in the table for insertion
        {
            bool isOpen = false;
            for (int i = 0; i < Size; i++)
            {
                if (Table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }

        public object Find(string key) {
            int hash = Math.Abs(key.GetHashCode()) % Size;
            while (Table[hash] != null && Table[hash].Key != key)
            {
                hash = (hash + 1) % Size;
            }
            if (Table[hash] == null)
            {
                return "Not Found";
            }
            else
            {
                return Table[hash].Value;
            }
        }

        public bool Contains(string key)
        {
            object item = Find(key);
            if (item.Equals("Not Found"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHash(string key) {
            int hash = Math.Abs(key.GetHashCode()) % Size;
            while (Table[hash] != null && Table[hash].Key != key)
            {
                hash = (hash + 1) % Size;
            }
            if (Table[hash] == null)
            {
                return 0;
            }
            else
            {
                return hash;
            }
        }
    }
}
