using System;

namespace _3._7_SkF_Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please: ");

            string Name = Console.ReadLine();

            Console.WriteLine("Enter your age, please: ");

            byte age = checked ((byte) int.Parse(Console.ReadLine()));

            Console.WriteLine("Your name is {0} and your age is {1}", Name, age);
           
            Console.ReadKey();
        }
    }
}
