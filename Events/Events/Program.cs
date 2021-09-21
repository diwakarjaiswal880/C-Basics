using System;

namespace Events
{
    public delegate string Del(string str);
    class EventBlock
    {
        event Del NewEvent;
        public EventBlock()
        {
            this.NewEvent += new Del(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome To Diwakar. " + username;
        }
        static void Main(string[] args)
        {
            EventBlock obj1 = new EventBlock();
            string result = obj1.NewEvent("Happy Learning");
            Console.WriteLine(result);
        }
    }
}
