using System;

namespace AnonymousFunction
{
    class Program
    {
        delegate int Square(int num);
        static void Main(string[] args)
        {
            //Lambda Expressions
            Square GetSquare = x => x * x;
            int j = GetSquare(25);
            Console.WriteLine("Square: " + j);
        }
    }
}


