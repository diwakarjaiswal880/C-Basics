using System;

namespace GenericsInAMethod
{
    class GenericClass
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass genC = new GenericClass();
            genC.Show("This message is from the generic method");
            genC.Show(321);
            genC.Show('H');
        }
    }
}
