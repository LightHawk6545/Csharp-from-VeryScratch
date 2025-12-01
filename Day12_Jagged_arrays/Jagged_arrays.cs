using System;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
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
            MobinGoodNews();
            AtAppleFarm();
        }

        private const string coco = "coco";
        private const string mobin = "mobin";
        private const string farmer = "farmer";

        private static void MobinGoodNews()
        {
            Scene("A random tuesday morning", ConsoleColor.White);
            Hold();

            Say(mobin, "Finally i made it!!");
            Say(mobin, "i can go there have some of the most fun");
            Hold();

            Say(coco, "not so fast mobin...");
            Say(coco, "as son as it gets to fun you forget there is a coco");
            Hold();

            Say(coco, "share the fun with me aswell");
            Say(mobin, "oh coco you have no idea");
            Hold();

            Say(mobin, "'ve been invited to the biggest apple farm of the country");
            Say(mobin, "as a token of gratitude for helping them build their application");
            Hold();

            Say(coco, "wow this is fantastic mobin how much can we harvest?");
            Say(mobin, "as much as we want.");
            Hold();

            Scene("Coco excitedly looking at mobin for what's coming", ConsoleColor.Magenta);
            Console.WriteLine();

            Drama("They go to their rooms and get their stuff ready for a day full of apples", ConsoleColor.Yellow);
            Hold();

            Say(mobin, "alright these are my baskets, my towel, a shoes for dirt and mud...");
            Say(mobin, "and a few snacks for evening");
            Hold();

            Scene("meanwhile coco...", ConsoleColor.Cyan);
            Hold();

            Say(coco, "okay this is my camera, extra clothes and some gifts for the farmers.");
            Hold();

            Drama("it is still early in the morning 8:00am and they plan to leave at 9:30am", ConsoleColor.Cyan);
            Hold();

            Scene("Soon it becomes 9:30 and they are ready to leave", ConsoleColor.White);
            Console.WriteLine();

            Say(mobin, "coco ready? can you count how many baskets we have total?");
            Say(coco, "okay thats 4, 7 and finally 10 baskets");
            Hold();

            Say(mobin, "alright so the summary is this");
            Say(mobin, "We have 2 small baskets, 3 medium and 5 large");
            Hold();

            Say(mobin, "we will see how many we can fit in each");
            Hold();
        }

        private static void AtAppleFarm()
        {
            Scene("Soon they arrive to the apple farm", ConsoleColor.Red);
            Hold();

            Say(farmer, "welcome folks, get yourself rested the apples won't run away");
            Hold();

            Say(mobin, "thank you we will have some fun today");
            Say(coco, "yes!!");
            Hold();

            Scene("Later on in the afternoon...", ConsoleColor.White);
            Hold();

            Drama("It was 12pm time to harvest apples", ConsoleColor.Cyan);
            Hold();

            Say(coco, $"mobin i harvested this tree got {baskets[0][0] + baskets[0][1]} apples in my small basket");
            Say(coco, "im filling my second!");
            Hold();

            Say(mobin, "well done coco, i beat you to that");
            Say(mobin, $"already filled {baskets[2][0] + baskets[2][1] + baskets[2][2]} apples in my medium basket");
            Hold();

            Scene("They looked at each other with a smile", ConsoleColor.White);
            Hold();

            Say(mobin, "coco what do you say we have a competition");
            Say(coco, "Whoever fills the large baskets first is the winner.");
            Hold();

            Say(coco, "Im in!");
            Hold();

            Scene("Over the next 1 hour they run around and fills their baskets.", ConsoleColor.Red);
            Hold();

            Say(mobin, $"2 baskets done!!!! {baskets[4][0] + baskets[4][1] + baskets[4][2]} apples in the first");
            Say(mobin, $"and {baskets[5][0] + baskets[5][1] + baskets[5][2]} in the second");
            Hold();

            Say(coco, "Oh mobin you're so fast!");
            Say(coco, $"i've done only one with {baskets[6][0] + baskets[6][1] + baskets[6][2]} apples");
            Hold();

            Say(mobin, "dont worry coco, its already great!");
            Console.WriteLine();

            int apples = TotalApples();

            Drama($"and at the end of the day they finished with total of {apples} apples!", ConsoleColor.Magenta);
            Hold();

            Say(farmer, "good yield boys, hope you enjoy those fresh apples");
            Hold();

            Say(mobin, "thank you so much for having us!");
            Say(coco, "yes thank you!");
            Hold();

            Say(farmer, "have a good day boys!");
            Console.WriteLine();

            Scene("and like that go home.");
            Hold();

            Drama("See you!", ConsoleColor.White);
            Hold();
        }

        private static readonly int[][] baskets =
            {
                new[] { 2, 3 },
                new[] { 3, 3 },
                new[] { 3, 3, 3 },
                new[] { 2, 3, 2 },
                new[] { 3, 4, 4 },
                new[] { 5, 5, 5 },
                new[] { 5, 3, 6 },
                new[] { 6, 3, 3 },
                new[] { 4, 3, 3 },
                new[] { 4, 3, 3 }
                };

        private static int TotalApples()
        {
            int totalApples = 0;

            foreach (var box in baskets)
            {
                foreach (int apple in box)
                    totalApples += apple;
            }

            return totalApples;
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

        private static void Drama(string drama, ConsoleColor? color = null)
        {
            drama = Capitalize(drama);
            if (color != null) Console.ForegroundColor = color.Value;
            for (int i = 0; i < drama.Length; i++)
            {
                Console.Write($"{drama[i]}");
                Thread.Sleep(1);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}