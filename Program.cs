using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Forgone";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            int num01 = 5;
            int num02 = 10;
            int num03 = 15;

            Console.WriteLine("Hello what's your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", nice to meet you.");
            Console.WriteLine("My name is YR-5000.\nI'm an AI sent from the future to destroy mankind.");
            Console.WriteLine("What's your favourite color?");

            string colorName = Console.ReadLine();

            Console.WriteLine("I like " + colorName + ", Its Awesome.");
            Console.WriteLine("What is your age?");

            string age = Console.ReadLine();

            Console.WriteLine("So, you're " + age + "years old.");
            Console.WriteLine("Credits:\nProgrammer: Muhammad Eshan\nCreator: Muhammad Eshan\nAgeofCreatorandProgrammer: 9, thank you for using my console(^o^).");

            Console.ReadKey();
        }
    }
}
