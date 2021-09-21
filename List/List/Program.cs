using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Sandhya");
            names.Add("Arun");
            names.Add("Prashanth");
            names.Add("Kiran");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
