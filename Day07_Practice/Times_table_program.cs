using System;

namespace Mobin_learning
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TimesTable();
        }

        static void TimesTable()
        {
            Say("System", "Welcome to times table tool!!", ConsoleColor.DarkYellow);
            Hold();
            Say("System", "The system will automtically calculate your table up to number 10");
            Hold();

            Say("System", "Please enter any number to get your times table", ConsoleColor.Magenta);

            bool success = int.TryParse(Console.ReadLine(), out int table);

            while (success = int.TryParse(Console.ReadLine(), out table))
            {
                Say("System", "Please consider a valid number. Try again...");
            }

            for (int times = 1; times <= 20;)
            {
                int result = times * table;
                Console.WriteLine($"[System] {table} x {times}: {result}");
                times++;
            }

            Hold();
            Say("System", "Thank you for using our tool.", ConsoleColor.DarkRed);
            Hold();

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