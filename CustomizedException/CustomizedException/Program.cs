using System;

namespace CustomizedException
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {
        }
    }
    class Program
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age is expected to be greater than 18");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Catch block is being executed now.");
        }
    }
}
