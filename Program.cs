using System;

namespace Hi_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you firstname?");
            string userFirstname = Console.ReadLine();
            Console.WriteLine("What is you Lastname?");
            string userLastname = Console.ReadLine();
            Console.WriteLine($"Hello, {userFirstname} {userLastname}!");
        }
    }
}
