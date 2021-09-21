using System;

namespace Destructors
{
    class Program
    {
        private double length;   // Length of a line

        public Program()
        {   // constructor
            Console.WriteLine("Object is being created");
        }
        ~Program()
        {   //destructor
            Console.WriteLine("Object is being deleted");
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
        }
    }
}
