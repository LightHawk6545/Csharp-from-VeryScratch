using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindingOut();
            AskingMath();
            Ending();
        }

        // A mini-practice for ternary operator.
        static void FindingOut()
        {
            Say("Mobin", "I hear a noise");
            Say("Mobin", "I hope that is not it...");
            Hold();

            SayColored("Mobin", "He slowly opens a certain door...", ConsoleColor.Magenta);
            Hold();

            Scene("Someone in the room moves quickly as if trying to hide something.", ConsoleColor.Red);
            Hold();

            Say("Mobin:", "COCO again?!");
            Hold();

            Say("Coco", "Mobin, i - ... i was trying to... ");
            Say("Mobin", "No COCO, why do i hear mobile noise from your blanket??");
            Hold();

            Say("Mobin", "You were supposed to be studying math.");
            Hold();
            Scene("Mobin intensely looking at coco.", ConsoleColor.DarkMagenta);

            Say("Mobin", "Be done in an hour i will be asking you.");
            Scene("Coco answers head down", ConsoleColor.Blue);
            Say("Coco", "Okay mobin.");
            Hold();
        }

        static void AskingMath()
        {
            Scene("An hour later...", ConsoleColor.Yellow);
            Hold();

            Say("Mobin", "Okay are you ready?");
            Say("Coco", "Yes.");
            Hold();

            Say("Mobin", "What is 9 x 9?");
            Say("Coco", "Uhm it is...");

            bool answer = float.TryParse(Console.ReadLine(), out float numberAnswered);


            while (numberAnswered != 81)
            {
                Say("Mobin", "Wrong coco, one more time...");
                float.TryParse(Console.ReadLine(), out numberAnswered);
            }

            Say("Mobin", "Well done coco!");
            Say("Mobin", "Answer the next one too to get a special prize.");
            Hold();

            Scene("Coco feels nervous and excited", ConsoleColor.DarkCyan);
            Hold();

            Say("Coco", "I will get it!!");
            Hold();

            Say("Mobin", "What is 40 divided by 2?");
            Scene("Coco gets ready to answer right away...", ConsoleColor.DarkGreen);
            Say("Coco", "Okay it is...");

            bool answerTwo = float.TryParse(Console.ReadLine(), out float numberAnsweredTwo);

            // Keep asking until answer is 20
            while (numberAnsweredTwo != 20)
            {
                string divisionAnswer =
                    numberAnsweredTwo == 20
                    ? "[Mobin] You're my coco!!"
                    : "[Mobin] It wasn't that hard, Coco...";

                string rewardOne =
                    numberAnsweredTwo == 20

                    ? "[Mobin] Your reward is your favorite food today!"
                    : "[Mobin] But hey, here's a secret: if you study a little more, I'll give you the reward.";

                Console.WriteLine(divisionAnswer);
                Console.WriteLine(rewardOne);

                float.TryParse(Console.ReadLine(), out numberAnsweredTwo);
            }


        }

        static void Ending()
        {
            Say("Mobin", "Okay my sweet coco, good job on studying");
            Hold();

            Scene("Coco feels so happy", ConsoleColor.Cyan);
            Hold();

            Say("Coco", "Thank you mobin!!");
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

        static void Scene(string scene, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"* {scene} *");
            Console.ResetColor();
        }

        static void SayColored(string character, string line, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{character}: {line}");
            Console.ResetColor();
        }
    }
}
