using System;
using System.Collections.Generic;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            LList one = new LList(new Node(5));
            one.Add(new Node(3));
            one.Add(new Node(1));
            one.Print();

            LList two = new LList(new Node(6));
            two.Add(new Node(4));
            two.Add(new Node(2));
            two.Print();

            LList result = Merge(one, two);
            result.Print();
        }

        static LList Merge(LList one, LList two)
        {
            if (one == null)
            {
                return two;
            }

            if (two == null)
            {
                return one;
            }
            
            while (one.Current.Next != null && two.Current != null)
            {
                Node oneNext = one.Current.Next;
                Node twoNext = two.Current.Next;
                one.Current.Next = two.Current;
                two.Current.Next = oneNext;
                two.Current = twoNext;
                one.Current = oneNext;
            }

            if ( two.Current != null)
            {
                one.Current.Next = two.Current;
            }
            
            return one;
        }
    }

}
