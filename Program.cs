using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity Stealer!");

            //Gather data        
            Console.WriteLine("Can you give me your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Can you give me your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Can you give me your hometown?");
            string hometown = Console.ReadLine();

            Console.WriteLine("Can you give me your favorite food?");
            string food = Console.ReadLine();

            //display data in a nice and pretty formatted way
            Console.WriteLine($"Your name is {name}.Your age is {age}.Your hometown is {hometown}. Your favorite food is {food}");


        }
    }
}
