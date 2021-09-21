using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<string> names = new Queue<string>();
            var names = new Queue<string>();
            names.Enqueue("Srujan");
            names.Enqueue("Prajat");
            names.Enqueue("John");
            names.Enqueue("Raju");
            names.Enqueue("Hari");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}
