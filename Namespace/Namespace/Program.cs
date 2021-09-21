using System;
using First;
using Second;
namespace First
{
    public class Diwakar
    {
        public void sayWelcome() { Console.WriteLine("Welcome To Diwakar"); }
    }
}
namespace Second
{
    public class Happy_Learning
    {
        public void sayWishes() { Console.WriteLine("Happy Learning"); }
    }
}
namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Diwakar h1 = new Diwakar();
            Happy_Learning w1 = new Happy_Learning();
            h1.sayWelcome();
            w1.sayWishes();
        }
    }
}
