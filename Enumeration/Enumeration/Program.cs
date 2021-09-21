using System;

namespace Enumeration
{
    class Program
    {
        public enum week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        static void Main(string[] args)
        {
            int x = (int)week.Monday;
            int y = (int)week.Friday;
            Console.WriteLine("Monday = {0}", x);
            Console.WriteLine("Friday = {0}", y);
        }
    }
}
