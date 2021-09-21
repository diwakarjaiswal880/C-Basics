using System;

namespace CallByReference
{
    class Program
    {
        public void Show(ref int val)
        {
            val *= val;
            Console.WriteLine("The value inside the show function " + val);
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before calling the function " + val);
            program.Show(ref val);
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
