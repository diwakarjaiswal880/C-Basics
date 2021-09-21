using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Sunil");
            names.Add("Amar");
            names.Add("Pujari");
            names.Add("Imran");
            names.Add("Amar");
            names.Add("karan");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
