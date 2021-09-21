using System;

namespace Constructors
{
    class Program
    {
        private double length;   // Length of a line

        public Program()
        {
            Console.WriteLine("Object is being created");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Program line = new Program();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
