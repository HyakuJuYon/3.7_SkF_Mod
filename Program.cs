using System;

namespace _3._7_SkF_Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age, please: ");

            byte age = checked ((byte) int.Parse(Console.ReadLine()));

            Console.WriteLine("Your age is {0}", age);
           
            Console.ReadKey();
        }
    }
}
