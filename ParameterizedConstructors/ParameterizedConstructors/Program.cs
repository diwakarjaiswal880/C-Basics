using System;

namespace ParameterizedConstructors
{
    class Program
    {
        private double length;   // Length of a line

        public Program(double len)
        {  //Parameterized constructor
            Console.WriteLine("Object is being created, length = {0}", len);
            length = len;
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
            Program line = new Program(10.0);
            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
