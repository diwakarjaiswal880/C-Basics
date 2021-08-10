using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Ram";
            int age = 22;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello " + fname + ", your age is " + age);

            Console.WriteLine("Please Enter your Name");
            String yourName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, Let's learn C#", yourName);


            Console.WriteLine("\n*****************************************************************\n");


            //Make decisions using the if statement
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            Console.WriteLine("\n*****************************************************************\n");

            //Make if and else work together
            a = 5;
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            Console.WriteLine("\n*****************************************************************\n");


            a = 5;
            b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            Console.WriteLine("\n*****************************************************************\n");

            //Use loops to repeat operations
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine("\n*****************************************************************\n");


            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 5);
            Console.WriteLine("\n*****************************************************************\n");

            //Work with the for loop
            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine($"Hello World! The counter is {count}");
            }
            Console.WriteLine("\n*****************************************************************\n");

            //Created nested loops
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            Console.WriteLine("\n*****************************************************************\n");

            //Create lists
            var names = new List<string> { "<name>", "DJ", "Ram" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("\n*****************************************************************\n");

            //Modify list contents
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("DJ");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Maria");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToLower()}!");
            }
            Console.WriteLine("\n*****************************************************************\n");


            // Program for List of fibonacci Numbers
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.WriteLine("\n*****************************************************************\n");

        }
    }
}
