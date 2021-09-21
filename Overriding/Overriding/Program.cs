using System;

namespace Overriding
{
    public class Tomy
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating ");
        }
    }
    public class Dog : Tomy
    {
        public override void eat()
        {
            Console.WriteLine("Eating food");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog();
            d.eat();
        }
    }
}
