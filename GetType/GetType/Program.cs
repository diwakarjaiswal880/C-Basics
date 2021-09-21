using System;

namespace GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            char ch = 'd';
            string  s1 = "diwakar";
            String dj = "hello";
            Type type1 = a.GetType();
            Console.WriteLine(type1);
            Type type2 = ch.GetType();
            Console.WriteLine(type2);
            Type type3 = s1.GetType();
            Console.WriteLine(type3);
            Type type4 = dj.GetType();
            Console.WriteLine(type4);

            Console.WriteLine(s1);
            Console.WriteLine(dj);

            Type t = typeof(System.String);
            Console.WriteLine(t.Assembly);

            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsInterface);
        }
    }
}
