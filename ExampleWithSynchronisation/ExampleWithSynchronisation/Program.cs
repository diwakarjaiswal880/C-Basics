using System;
using System.Threading;
class Diwakar
{
    public void PrintTable()
    {
        lock (this)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }
    }
}
namespace ExampleWithSynchronisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Diwakar p = new Diwakar();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
        }
    }
}
