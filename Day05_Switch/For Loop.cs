using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoryBegins();
            AtBank();
            BackHome();
        }


        // An experiment on while loop.

        // A story on withdrawing money from the bank.
        static void StoryBegins()
        {
            Say("Mobin", "Ive got to pay my loan today. ");
            Say("Mobin", "What do you think coco, will i forget the pin again?");

            Hold();

            Say("Coco", "I mean, its not your card, thats why you forget, try your best tho.");
            Console.WriteLine();
            Hold();

            Scene("Mobin leaves to the bank with uncertainty");
            Scene("After 5 minutes he arrives there");
            Hold();
        }

        static void AtBank()
        {
            Say("Mobin", "Okay let me try inserting my card in the ATM... (it is 3185)");
            Hold();


            int pin = 0;

            while (pin != 3185)
            {


                Say("ATM", "Please enter pin: ");
                bool attemptingPin = int.TryParse(Console.ReadLine(), out pin);

            }

            Console.WriteLine("Thank you, here is your 100,000$ cash.");
            Hold();



        }

        static void BackHome()
        {
            Say("Mobin", "Ah I recently changed the lock... now which is my home key?");
            Say("Mobin", "There is a blue, red and green key, I guess I'll try each.");
            Hold();
            Say("Mobin", "Alright... type a key color:");

            string tryKey = Console.ReadLine();

            while (tryKey != "red")
            {
                Say("Mobin", "That's not it...");
                Say("Mobin", "Let me try another key...");

                tryKey = Console.ReadLine(); 
            }

            Say("Mobin", "Finally it worked, it's red.");
            Hold();
            Say("Mobin", "Alright i can get some rest now.");
            Hold();
        }

        static void Hold()
        {
            Console.ReadLine();
        }

        static void Say(string message, string line)
        {
            Console.WriteLine($"[{message}] {line}");
        }

        static void Scene(string scene)
        {
            Console.WriteLine($"* {scene} *");
        }

        static void SayColored(string character, string line, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{character}: {line}");
            Console.ResetColor();
        }

    }
}