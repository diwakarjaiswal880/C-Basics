using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> names = new SortedList<int, string>();
            names.Add(1, "Arun");
            names.Add(4, "Vishal");
            names.Add(5, "Ramesh");
            names.Add(3, "Vidya");
            names.Add(2, "Pallavi");
            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            foreach (KeyValuePair<string, string> kv in cities)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
