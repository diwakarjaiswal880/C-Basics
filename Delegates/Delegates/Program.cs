using System;

namespace Delegates
{
    delegate int Calculator(int n);
    class Program
    {
        static int number = 25;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            c1(20);
            Console.WriteLine("After calculator one delegate, the new Number is: " + getNumber());
            c2(3);
            Console.WriteLine("After calculator two delegate, the new Number is: " + getNumber());
        }
    }

}
