using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Chandan");
            names.Push("Pooja");
            names.Push("James");
            names.Push("Rajesh");
            names.Push("kumar");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
        }
    }
}
