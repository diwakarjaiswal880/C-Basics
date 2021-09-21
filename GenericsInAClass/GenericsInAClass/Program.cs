using System;

namespace GenericsInAClass
{
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This message is from generic class");
            GenericClass<int> genI = new GenericClass<int>(123);
            GenericClass<char> getCh = new GenericClass<char>('E');
        }
    }
}
