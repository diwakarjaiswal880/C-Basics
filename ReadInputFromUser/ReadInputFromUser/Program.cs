using System;

namespace ReadInputFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers for addition : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {a} and {b} = {a+b}");
            Console.ReadKey();

        }
    }
}
