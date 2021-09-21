using System;
using System.Linq;

namespace LINQQueryToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = (from n in numbers

                           where (n % 2 == 0)
                          
                           orderby n

                           select n);


            Console.WriteLine("Select even number only");
            foreach(var i in lowNums)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        
        }
    }
}
