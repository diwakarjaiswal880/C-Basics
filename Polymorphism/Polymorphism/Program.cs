using System;

namespace Polymorphism
{
    public class Animal
    {
        public string color = "white";
    }
    public class Dog : Animal
    {
        public string color = "black";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);
        }
    }
}
