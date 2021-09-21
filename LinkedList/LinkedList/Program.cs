using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Rajat");
            names.AddLast("Arun");
            names.AddLast("Prakash");
            names.AddLast("jay");
            names.AddFirst("sai");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
