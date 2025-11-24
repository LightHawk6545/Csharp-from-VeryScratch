using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheCall();
            PrintingModels();
            RecievingPrints();
            LeavingTheStore();
        }

        // For Loop mini practice.

        // -- Part 1 --
        static void TheCall()
        {
            Console.WriteLine(" (*Phone starts ring at 9 a.m in the morning*) ");
            Hold();
            Console.WriteLine(" *Someone picked up* ");
            Hold();

            Console.WriteLine("Operator: Hello, this is mary calling from printing center");
            Console.WriteLine("Your custom 3D models are ready to be printed, we need you here to sign the contract to start printing ");
            Hold();

            Console.WriteLine("*Mysterious person reveals their voice*");
            Console.WriteLine("Mobin: Alright thank you very much i'll be there at 10 a.m");
            Hold();
        }

        // -- Part 2 --
        static void PrintingModels()
        {
            Console.WriteLine("* A black car parked at printing center at that time *");
            Console.WriteLine("* Mobin had just arrived there *");
            Hold();

            Console.WriteLine("Mobin: Hello, im here to sign...");
            Console.WriteLine("Mary: Weclome, please here and there.");
            Console.WriteLine("Very good, we can start, you can wait and watch the machine 3D while it operates");
            Hold();

            Console.WriteLine("Over the next 30 minutes: (The machine logged each succesful print.) ");
            for (int print = 1; print <= 5; print++)
            {
                Console.WriteLine($"3D model number {print}, is ready.");
                Hold();
            }
        }
        // -- part 3 --
        static void RecievingPrints()
        {
            Console.WriteLine("Mobin: okay that is all of the models, how can i pay?");
            Console.WriteLine("Mary: Cash please, it will be 100 dollars");
            Hold();

            Console.WriteLine("Mobin: Oh looks like im missing 30 dollars, let me search im sure i have it");
            Console.WriteLine("* Mobin eventually found extra cash and counted them");
            Hold();

            Console.WriteLine("There i go, i'll count so i don't miss the number");
            Hold();

            int money = 70;
            for (int count = money; money <= 100; money += 10)
            {
                Console.WriteLine($"That's {money}");
                Hold();

            }
        }
            static void LeavingTheStore()
            {
                Console.WriteLine("Mary: Thank you very much sir, that will do.");
                Console.WriteLine("Have a good day.");
                Console.WriteLine("Mobin: Thank you for your service, cheers.");
                Hold();
            }



        static void Hold()
        {
            Console.ReadLine();
        }
    }
}