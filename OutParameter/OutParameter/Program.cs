using System;

namespace OutParameter
{
    class Program
    {
        public void Show(out int val)
        {
            int square = 5;
            val = square;
            val *= val;
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before passing out variable " + val);
            program.Show(out val);
            Console.WriteLine("Value after recieving the out variable " + val);
        }
    }
}
