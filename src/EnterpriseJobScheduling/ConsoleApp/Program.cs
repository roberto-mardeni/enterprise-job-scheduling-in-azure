using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Environment.GetEnvironmentVariable("ConsoleAppName");

            Console.WriteLine($"Hello World, from {name}, at {DateTime.Now}!");
        }
    }
}
