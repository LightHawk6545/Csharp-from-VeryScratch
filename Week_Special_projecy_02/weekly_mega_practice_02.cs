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
            StoryBegins();
            CocoBankAccount();
            CocoGoesCinema();
        }

        // saves typing time
        private const string mobin = "mobin";

        private const string coco = "coco";
        private const string jenny = "jenny";

        // >> weekend project <<
        // == main storyline ==
        private static void StoryBegins()
        {
            Scene("It was a warm summer day", ConsoleColor.Yellow);
            Hold();

            Scene("The story begins with jenny, coco and mobin", ConsoleColor.Green);
            Hold();

            Say("Mobin", "It is such a great day coco");
            Say("coco", "mobin, come on, i assume we are not talking about that.");
            Hold();

            Say("mobin", "Oh come on coco");
            Hold();

            Say("mobin", "Its your birthday!!!!");
            Say("mobin", "And your cousin jenny is coming over  ");
            Hold();

            Say("coco", "you know what i like about my birthday?");
            Say("coco", "that you won't let it slide without a plan");
            Hold();

            Say("mobin", "well you already know coco, i love planni -");
            Hold();

            Dramatic("Ding Dong", ConsoleColor.Magenta);
            Hold();

            Say("Mobin & Coco", "Oh its jenny!");
            Hold();

            Say("jenny", "Hello mobin and coco");
            Say("jenny", "And happy birthday coco!");
            Hold();

            Say("Coco", "Thank you so much!");
            Say("Jenny", "So what is your plan for today?");
            Hold();

            Say("Mobin", "Good question jenny");
            Say("Mobin", "today, we have a room full of plans for coco");
            Hold();

            Dramatic("Coco and jenny staring at mobin", ConsoleColor.Blue);
            Hold();

            Say("mobin", "We will have a tour in the city and explore many places");
            Say("mobin", "are you both ready?");
            Hold();

            Say("Coco & Jenny", "Yes!!");
            Hold();
        }

        private static void CocoBankAccount()
        {
            Dramatic("Mobin, jenny and coco put on their shoes and go outside", ConsoleColor.DarkRed);
            Console.WriteLine();
            FindCocoShoes();

            Say("Mobin", "Alright get in the car and buckle up sit belts");
            Say("Mobin", "And each one of you tell me where you want to go");
            Hold();

            Scene("He starts the engine and drives the car", ConsoleColor.White);
            Hold();

            for (int i = 0; i <= 2; i++)
            {
                Thread.Sleep(1000);
                switch (i)
                {
                    case 0:
                        Say("Jenny", "i wanna go to the cinema");
                        Console.WriteLine();
                        break;

                    case 1:
                        Say("Coco", "wherever mobin says!!");
                        Console.WriteLine();
                        break;

                    case 2:
                        Say("mobin", "And now i say... we go to the bank");
                        break;
                }
            }

            Console.WriteLine();
            Scene("Coco and jenny couldn't help but to get confused", ConsoleColor.Magenta);
            Hold();

            Say("Coco", "Mobin, why the bank?");
            Hold();

            Say("mobin", "well, we will see in a bit.");
            Console.WriteLine();

            Scene("They got to the bank", ConsoleColor.DarkRed);
            Hold();

            Say("mobin", "Okay lets create your first own bank account coco, happy birthday!");
            Say("mobin", "with 1000$ gift from me");
            Hold();

            Say("coco", "Wow mobin thank you so much!!!");
            Hold();

            Say("Bank operator", "Hello sir, whose name do you want to register on this card?");
            Hold();

            Say("mobin", "coco, please.");
            Hold();

            Say("bank operator", "mr coco can you please read this form for password");
            Hold();

            SetCocoPasswordDigital();
            SetCocoPin();

            Say(mobin, "what do you say we withdraw some money?");
            Say(jenny, "yes coco try your card for the first time!");
            Hold();

            Say(coco, "im down lets do it.");
            Console.WriteLine();

            CocoWithdrawMoney();
        }

        private static void CocoGoesCinema()
        {
            Console.WriteLine();
            Say(mobin, "alright, anyways, who is down for some delicious chocolate milk.");
            Hold();

            Say("Coco & Jenny", "me me me");
            Console.WriteLine();

            Scene("They sit on a park bench and have chocolate milk", ConsoleColor.Magenta);
            Hold();

            Say(jenny, "Mmm yummy, that was delicious");
            Say(coco, "mobin, next where?");
            Hold();

            Say(mobin, "are we good with cinema?");
            Console.WriteLine();

            Say(jenny, "yes, i agree!!");
            Say(coco, "im good with cinema too");
            Hold();

            Scene("Mobin drives and they get in time for tickets");
            Console.WriteLine();

            Say(mobin, "okay there is a movie upcoming in an hour");
            Hold();

            Say(mobin, "lets go ahead and buy some tickets");
            Console.WriteLine();

            Say("Ticket seller", "Hello how many tickets would you like?", ConsoleColor.Red);
            Hold();

            Say(mobin, "Three please.");
            Console.WriteLine();

            Say("Ticket seller", "it will be 20 dollars", ConsoleColor.Red);
            Hold();

            Say("Ticket seller", "how would you like to pay?", ConsoleColor.White);
            Hold();

            CinemaPayment();

            Dramatic("They spend 3 hours watching a movie", ConsoleColor.Cyan);
            Console.WriteLine();

            Scene("it was great.");

            Say(coco, "such amazing movie!!");
            Console.WriteLine();

            Say(jenny, "mhm yes! im tired of all this adventure now");
            Hold();

            Say(mobin, "what do you say go home?");
            Say(coco, "i agree.");
            Console.WriteLine();

            Say(jenny, "me too.");
            Hold();

            Dramatic("And like this the story has just ended.", ConsoleColor.Yellow);
            Hold();

            Dramatic("See you!");
            Hold();
        }

        // methods and user interactions.
        private static void FindCocoShoes()
        {
            Scene("Talking about leaving coco doesn't seem to be finding something, he lost his precious shoes");
            Console.WriteLine();

            Scene("Coco wants to cry of sadness, perhaps you can help him find his shoes.");
            Console.ReadLine();

            Say("coco", "did i put it behind the flower pot, in my room, or on the grass in the other yard?");
            Console.WriteLine("Which one do you think it is? Flower Pot, Room or Yard?");

            string choice = "";

            while (true)
            {
                choice = FindMethod();

                if (choice.Equals("flower pot", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Say("coco", "there is nothing here but dirt.");
                    Hold();

                    Say("coco", "Maybe somewhere else...");
                    Hold();

                    Console.WriteLine("Choose another place:");
                }
                else if (choice.Equals("room", StringComparison.OrdinalIgnoreCase))
                {
                    Say("Coco", "nope, it's clean but I don't see my shoes.");
                    Hold();

                    Say("coco", "maybe if I give it another go...");
                    Hold();

                    Console.WriteLine("Choose another place:");
                }
                else if (choice.Equals("yard", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Say("coco", "seems like I will never find it...");
                    Hold();

                    Say("coco", "Oh what is that?");
                    Say("coco", "Yes it is here!!! I left it behind the clothes to dry!");
                    Hold();

                    break;
                }
                else
                {
                    Console.WriteLine("That doesn't seem to be a place. Try again.");
                }
            }

            Scene("Back to the story...", ConsoleColor.Blue);
            Hold();
        }

        private static string cocoDigitalPassword;

        private static string SetCocoPasswordDigital()
        {
            Say("Form", "There are two password you should set, a pin and a digital password", ConsoleColor.Green);
            Console.WriteLine();
            Say("Form", "Pin must be at most 6 number and digital password at least 8 characters long.", ConsoleColor.Green);
            Hold();

            Say("Bank operator", "please enter your digial password");

            string cocoPassword = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(cocoPassword) || cocoPassword.Length < 8 || cocoPassword.Length > 30)
            {
                if (string.IsNullOrEmpty(cocoPassword))
                {
                    Say("bank operator", "we can't use this... please enter a valid character.");
                    cocoPassword = Console.ReadLine();
                }
                else if (cocoPassword.Length < 8)
                {
                    Say("Bank operator", "That password is too short. It must be at least 8 characters.");
                    cocoPassword = Console.ReadLine();
                }
                else if (cocoPassword.Length > 12)
                {
                    Say("Bank operator", "That's too long. Maximum allowed is 30 characters.");
                    cocoPassword = Console.ReadLine();
                }
            }

            Console.WriteLine();
            Say("Bank operator", "Thank you for setting up digital password");
            Say("bank opeator", "Please don't forget your password.");
            Hold();

            Say("Bank operator", "To encrypt your data in our system we will reverse your password");
            Console.WriteLine();

            for (int i = cocoPassword.Length - 1; i >= 0; i--)

            {
                Console.Write(cocoPassword[i]);
                Thread.Sleep(55);
            }

            cocoDigitalPassword = cocoPassword;
            Console.WriteLine();
            return cocoPassword;
        }

        // Shared PIN variable
        private static string CocoPin;

        private static bool isPinForgotten = false;

        private static string SetCocoPin()
        {
            Say("Bank operator", "Please set up your pin for ATM usage.");
            Console.WriteLine();

            string input;
            bool isValid;

            do
            {
                Say("Bank operator", "Enter pin (6 to 8 digits):");
                input = Console.ReadLine()?.Trim() ?? "";

                isValid = int.TryParse(input, out _) &&
                          input.Length >= 6 &&
                          input.Length <= 8;

                if (!isValid)
                    Say("Bank operator", "Invalid pin. Please enter 6 to 8 numeric digits.");
            } while (!isValid);

            CocoPin = input;

            Console.WriteLine();
            Say("Bank operator", "Pin set successfully.");
            Console.WriteLine($"Your pin is now: {CocoPin}");
            Hold();

            return CocoPin;
        }

        // withdraw money
        private static void CocoWithdrawMoney()
        {
            Scene("They go to the ATM next to the bank.", ConsoleColor.Cyan);
            Hold();

            if (string.IsNullOrWhiteSpace(CocoPin))
            {
                Say("ATM", "Error: No PIN found. Please set PIN first.");
                return;
            }

            while (true)
            {
                Say("ATM", "Please enter PIN:");
                string input = Console.ReadLine()?.Trim() ?? "";

                if (!int.TryParse(input, out _))
                {
                    Say("ATM", "PIN must be numeric.");
                    continue;
                }

                if (input == CocoPin)
                {
                    Say("ATM", "Correct PIN.");
                    Say("ATM", "100$ is ready to withdraw.");
                    Hold();

                    Say("Coco", "Hooray! This is my first money withdrawal.");
                    Say("Coco", "I'll put it to good use.");
                    Hold();
                    break;
                }

                // Incorrect PIN flow
                Say("ATM", "Incorrect PIN.");
                Say("ATM", "Would you like to try again? (yes / no)");
                string retry = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (retry == "no")
                {
                    Say("Mobin", "Aw, it's okay Coco. I can withdraw for you. For now, let's get a drink...");
                    Hold();
                    isPinForgotten = true;
                    break;
                }
            }

            // Ask about resetting the PIN
            string resetChoice;
            do
            {
                Say("ATM", "Would you like to reset your PIN? (yes / no)");
                resetChoice = Console.ReadLine().Trim().ToLower();
            } while (resetChoice != "yes" && resetChoice != "no");

            if (resetChoice == "no")
            {
                Say("ATM", "Thank you for using our service.");
                return;
            }

            // Set new PIN
            while (true)
            {
                Say("ATM", "Enter new PIN (6 to 8 digits):");
                string newPin = Console.ReadLine().Trim();

                if (!int.TryParse(newPin, out _) || newPin.Length < 6 || newPin.Length > 8)
                {
                    Say("ATM", "Invalid PIN. Please enter a 6-8 digit numeric PIN.");
                    continue;
                }

                CocoPin = newPin;
                isPinForgotten = false;
                Say("ATM", "Your new PIN has been set successfully.");
                Hold();
                break;
            }
        }

        private static void CinemaPayment()
        {
            if (!isPinForgotten)
            {
                Say(coco, "i will pay.");
                Hold();
            }
            else if (isPinForgotten)
            {
                Say(mobin, "i got this.");
                Hold();

                Console.WriteLine("Mobin", "okay my digital pass should be: MobMob32");
                Console.WriteLine("Mobin", "and pin: 858531");
                Hold();
            }

            Say("ticket seller", "How would you like to pay?, select digital or pin.", ConsoleColor.White);

            string choice = Console.ReadLine().Trim().ToLower();

            while (true)
                if (choice == "digital")
                {
                    DigitalPayment();
                    break;
                }
                else if (choice == "pin")
                {
                    PinPayment();
                    break;
                }
                else
                {
                    Say("ticket seller", "choose pin or digital, try again.");
                    choice = Console.ReadLine().Trim().ToLower();
                }
        }

        private static void DigitalPayment()
        {
            Say("ticket seller", "welcome to digital payment", ConsoleColor.Red);
            Hold();

            Say("ticket seller", "Please enter your digial pass here: ", ConsoleColor.Red);

            string password = "";
            string mobinPassword = "MobMob32";

            while (true)
            {
                password = Console.ReadLine().Trim();
                if (password == cocoDigitalPassword)
                {
                    Say("ticket seller", "thank you for your payment", ConsoleColor.White);
                    Say("Ticket seller", "please take your sits in the cinema, the movie is starting soon.", ConsoleColor.White);
                    break;
                }
                if (password == mobinPassword)
                {
                    Say("ticket seller", "thank you for your payment", ConsoleColor.White);
                    Say("Ticket seller", "please take your sits in the cinema, the movie is starting soon.", ConsoleColor.White);
                    break;
                }
                else if (string.IsNullOrEmpty(password) || password != cocoDigitalPassword)
                {
                    Say("ticket seller", "Incorrect or empty password.", ConsoleColor.Red);

                    Say("ticket seller", "would you like to try pin payment? (yes / no)", ConsoleColor.Red);
                    password = Console.ReadLine().Trim().ToLower();
                    if (password == "yes")
                    {
                        PinPayment();
                        break;
                    }
                    else if (password == "no")
                    {
                        continue;
                    }
                }
            }
        }

        private static void PinPayment()
        {
            Say("Ticket seller", "This is the pin payment", ConsoleColor.White);
            Hold();

            Say("ticket seller", "Plese enter your pin:", ConsoleColor.White);
            Console.WriteLine();

            if (isPinForgotten)
            {
                Say(mobin, "so my pin is 858531, just in case i forget it");
            }

            string cinemaPin = "";
            string mobinPin = "858531";

            while (true)
            {
                cinemaPin = Console.ReadLine().Trim();

                if (cinemaPin == CocoPin)
                {
                    Say("ticket seller", "thank you please go ahead take your seats.", ConsoleColor.Red);
                    Hold();
                    break;
                }
                if (cinemaPin == mobinPin)
                {
                    Say("ticket seller", "thank you please go ahead take your seats.", ConsoleColor.Red);
                    Hold();
                    break;
                }
                else if (string.IsNullOrEmpty(cinemaPin) || cinemaPin != CocoPin)
                {
                    Say("ticket seller", "invalid pin, please provide a correct pin", ConsoleColor.White);
                    continue;
                }
            }
        }

        private static string FindMethod()
        {
            string findShoes = Console.ReadLine().ToLower().Trim();

            while (string.IsNullOrEmpty(findShoes))
            {
                Console.WriteLine("That doesn't get us anywhere... give it another go");
                findShoes = Console.ReadLine().ToLower().Trim();
            }
            return findShoes;
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