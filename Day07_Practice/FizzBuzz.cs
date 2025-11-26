using System;

namespace Day_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        static void FizzBuzz()
        {
            Say("Operator", "Welcome to fizz buzz", ConsoleColor.Red);
            Hold();

            Say("Operator", "Please enter any number:");

            bool game = int.TryParse(Console.ReadLine(), out int number);
            while (game == false)
            {
                Say("Operator", "That's not working, enter a valid number.");
                game = int.TryParse(Console.ReadLine(), out number);
            }

            // Count down from the entered number to 1
            for (; number >= 1; number--)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Say("Operator", "FizzBuzz!", ConsoleColor.Yellow);
                }
                else if (number % 3 == 0)
                {
                    Say("Operator", "Fizz!", ConsoleColor.Green);
                }
                else if (number % 5 == 0)
                {
                    Say("Operator", "Buzz!", ConsoleColor.Cyan);
                }
                else
                {
                    Say("Operator", number.ToString(), ConsoleColor.White);
                }

                if (number == 1)
                {
                    Console.WriteLine();
                    Say("Operator", "Game over! Thanks for playing.", ConsoleColor.Red);
                    Hold();
                }
            } 

        }

        static void Hold()
        {
            Console.ReadLine();
        }

        static void Say(string speaker, string text, ConsoleColor? color = null)
        {
            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        static void Scene(string scene)
        {
            Console.WriteLine($"* {scene} *");
        }
    }
}