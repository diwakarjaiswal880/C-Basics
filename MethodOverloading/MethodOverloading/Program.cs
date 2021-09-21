using System;

namespace MethodOverloading
{
    public class Diwakar
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diwakar.add(12, 23));
            Console.WriteLine(Diwakar.add(12.4f, 21.3f));
        }
    }
}
