using System;

namespace MemberOverloading
{
    public class Diwakar
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diwakar.add(12, 23));
            Console.WriteLine(Diwakar.add(12, 23, 25));
        }
    }
}
