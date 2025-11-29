using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Xml.Schema;

namespace Mobin_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayingAtHome();
            AtTheYard();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";

        private static void PlayingAtHome()
        {
            Dramatic("A cold day in winter.", ConsoleColor.Cyan);
            Hold();

            Say(coco, "i need to check the hens and harvest their eggs");
            Hold();

            Scene("two days ago.", ConsoleColor.White);

            Say(mobin, "coco i will leave the hens to you count them and tell me when i return");
            Hold();

            Say(coco, "Alright i will get outside and get started.");
            Console.WriteLine();

            Scene("coco goes to the yard near the chickens and starts counting", ConsoleColor.DarkYellow);
            Console.WriteLine();
        }

        private static void AtTheYard()
        {
            Scene("Coco collected a list of hens.", ConsoleColor.DarkYellow);
            Hold();

            HenCalculation();

            Say(coco, "Alright job done, i'll leave 3 eggs from each basket for mobin to inspect them.");
            Hold();

            eggsCount[0] -= 3;
            eggsCount[1] -= 3;

            Say(coco, "now each basket has: ");
            Console.WriteLine();

            foreach (var item in eggsCount)
            {
                Console.WriteLine($"{item} eggs");
                Console.WriteLine();
            }

            Say(coco, "now i will get some rest");
            Hold();
        }

        private static int[] eggsCount = new int[] { 5, 5 };
        private static int[] hensCount = { 4, 4 };

        private static void HenCalculation()
        {
            Say(coco, "okay there are two places and each has 4 hens");
            Console.WriteLine();

            hensCount[1]--;

            Console.WriteLine($"first has {hensCount[0]}, and second {hensCount[1]}");
            Say(coco, "wait that's not right");
            Hold();

            Say(coco, "let me see if i have gone through the two fields well");
            Console.WriteLine();

            foreach (int check in hensCount)
            {
                Console.Write($"[{check}] hens, ");
            }
            Console.WriteLine("that is both of the fields, yep one hen is missing");
            Hold();

            Say(coco, "i'll collect the eggs and get to that one soon");
            Hold();

            Say(coco, "7 hens produced around: ");
            Console.WriteLine();

            Dramatic("1, 2, 4, 8 and finally 10 eggs.", ConsoleColor.Green);
            Say(coco, "not bad for a cold weather, each of my basket hold 5 eggs.");
            Hold();

            Scene("coco hears a sound.", ConsoleColor.Cyan);
            Hold();

            Say(coco, "i know this sound, its coming from the other side of the yard");
            Say(coco, "oh its the hen, she has been hiding here!");
            Hold();

            hensCount[1]++;

            Console.WriteLine($"And with that it is {hensCount[1]} in the other field too.");
            Hold();
        }

        private static void Hold()
        {
            Console.ReadLine();
        }

        private static string Capitalize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Trim();

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private static void Say(string speaker, string text, ConsoleColor? color = null)
        {
            speaker = Capitalize(speaker);
            text = Capitalize(text);

            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"[{speaker}] {text}");
            Console.ResetColor();
        }

        private static void Scene(string scene, ConsoleColor? color = null)
        {
            if (color != null) Console.ForegroundColor = color.Value;
            Console.WriteLine($"* {scene} *");
            Console.ResetColor();
        }

        private static void Dramatic(string drama, ConsoleColor? color = null)
        {
            drama = Capitalize(drama);
            if (color != null) Console.ForegroundColor = color.Value;
            for (int i = 0; i < drama.Length; i++)
            {
                Console.Write($"{drama[i]}");
                Thread.Sleep(55);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}