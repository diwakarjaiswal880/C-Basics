using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1", "Arun");
            names.Add("4", "Vishal");
            names.Add("5", "Ramesh");
            names.Add("7", "Vidya");
            names.Add("2", "Pallavi");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
