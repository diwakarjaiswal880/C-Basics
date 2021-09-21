using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Shiva");
            names.Add("2", "Prasad");
            names.Add("3", "Preetam");
            names.Add("4", "Roy");
            names.Add("5", "Akash");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
