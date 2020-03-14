using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingGenerator = new GreetingGenerator();
            var greeting = greetingGenerator.GetGreeting();

            Console.WriteLine($"{greeting } World!");
        }
    }
}
