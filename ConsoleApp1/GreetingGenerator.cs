using System;

namespace ConsoleApp1
{
    public class GreetingGenerator
    {
        protected static string[] _greeting = new string[] { "Hallo", "Hello", "Greetings", "Ciao" };

        public string GetGreeting()
        {
            var random = new Random();
            return _greeting[random.Next(_greeting.Length)];
        }
    }
}
