using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("Sanjay");
            names.Add("Anuradha");
            names.Add("Praveen");
            names.Add("Ravi");
            names.Add("Praveen");
            names.Add("Kajol");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
