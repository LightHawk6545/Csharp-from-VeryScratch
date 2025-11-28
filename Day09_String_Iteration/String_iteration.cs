using System;
using System.Threading;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobinAndCoco();
            StartingToRecord();
        }

        // practicing string iteration and a few more features
        static void MobinAndCoco()
        {
            Say("mobin", "hey coco.");
            Hold();

            Say("coco", "hi mobin.");
            Say("coco", "you look like you've got something new");
            Hold();

            Say("mobin", "im glad you could tell.");
            Say("mobin", "have you seen people on social media doing slow motion trend?");
            Hold();

            Scene("Coco and mobin both get ready for fun", ConsoleColor.Yellow);
            Hold();

            Say("coco", "yes, wow im guessing you are doing that.");
            Say("mobin", "exactly");
            Hold();

        }

        static void StartingToRecord()
        {
            Say("coco", "how do we start?");

            Scene("Mobin sets up the camera for recording", ConsoleColor.DarkMagenta);
            Console.WriteLine();

            Say("mobin", "first we will need to play a game to get warmed up");
            Hold();

            Say("mobin", "i play a video and we call out the first two letters we hear");
            Say("mobin", "ready?");
            Hold();

            Scene("Coco fires up determination", ConsoleColor.DarkYellow);
            Console.WriteLine();

            Say("coco", "yes sir mobin!");
            Say("mobin", "alright my turn first");

            MobinCallOutTurn();

            Say("coco", "okay now comes my turn");
            Hold();

            CocoCallOutTurn();

            Say("mobin", "now what do you say we take a break champ");
            Say("coco", "im down, thank you for the game!");
        }


        static void Hold()
        {
            Console.ReadLine();
        }

        // it is a good practice to apply what i learnt to this case.
        static string Capitalize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Trim();

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        static void Say(string speaker, string text, ConsoleColor? color = null)
        {
            speaker = Capitalize(speaker);
            text = Capitalize(text);

            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        static void Scene(string scene, ConsoleColor? color = null)
        {

            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"* {scene} *");
            Console.ResetColor();


        }


        static void MobinCallOutTurn()
        {
            Say("mobin", "alright first is me");
            Hold();

            Say("Trending Video", "get ready", ConsoleColor.Red);
            Hold();

            for (int i = 3; i >= 1; i--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Trending Video] {i}");
                Thread.Sleep(1000);
                Console.ResetColor();
            }


            Say("trending video", "Call out Hippopotamus", ConsoleColor.Cyan);

            string mobinsAnswer = Console.ReadLine().Trim().ToLower();

            while (!mobinsAnswer.Equals("Hi", StringComparison.OrdinalIgnoreCase))
            {
                Say("coco", "Come on mobin, its the easiest ever! Try again!!!");
                mobinsAnswer = Console.ReadLine().Trim().ToLower();
            }

            Say("Coco", "perfect mobin you've got it right!!");
            Hold();

            Say("coco", "let me recap your turn, your word was:");
            Hold();

            string theOriginalWord = "Hippopotamus";

            for (int i = 0; i < theOriginalWord.Length; i++)
            {
                Console.Write(theOriginalWord[i]);
                Thread.Sleep(150);
            }

            Console.WriteLine();
            Hold();
            Say("coco", "and the first two letters were Hi, perfect.");
            Hold();
        }


        static void CocoCallOutTurn()
        {
            Say("mobin", "okay coco here is your word");
            Hold();

            Say("trending video", "Get ready", ConsoleColor.DarkMagenta);
            Hold();

            for (int i = 3; i >= 1; i--)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"[Trending Video] {i}");
                Thread.Sleep(1000);
                Console.ResetColor();
            }

            Console.WriteLine();
            Say("Trending video", "Call out rhinoceros", ConsoleColor.DarkYellow);

            string cocoAnswer = Console.ReadLine().Trim().ToLower();

            while (!cocoAnswer.Equals("Rh", StringComparison.OrdinalIgnoreCase))
            {
                Say("coco", "No coco not correct, come on you got this!!!");
                cocoAnswer = Console.ReadLine().Trim().ToLower();
            }

            Say("mobin", "yes coco! Correct!!");
            Hold();

            Say("mobin", "alright let me show you the word: ");
            Hold();

            string theOriginalWordCocoTurn = "Rhinoceros";

            for (int i = 0; i < theOriginalWordCocoTurn.Length; i++)
            {
                Console.Write(theOriginalWordCocoTurn[i]);
                Thread.Sleep(150);
            }

            Console.WriteLine();
            Hold();
            Say("mobin", "wonderful coco, we won!");
            Hold();

        }
    }
}
