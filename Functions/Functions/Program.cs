using System;

namespace Functions
{
    class Program
    {
        public string Show(string message)
        {
            Console.WriteLine("Inside Show Function");
            return message;
        }
        static void Main(string[] args)
        {
            
            Program demo = new Program();
            string message = demo.Show("To Delhi");
            Console.WriteLine("Welcome " + message);
        }
    }
}
