using System;

namespace Mobin_learning
{
    internal class Program
    {
        static void GuessItem()
        {
            Console.WriteLine("Alright Lets begin your game, Press Enter Once And Make Your Guess!");
            Console.ReadLine();
            string userGuesesNumber = Console.ReadLine();
            Console.WriteLine("Alright lets see... your number of choice was: " + userGuesesNumber);
            Console.ReadLine();

            if (userGuesesNumber == "4")
            {
                Console.WriteLine("Congratulations, You won!!");
                Console.ReadLine();
                Console.WriteLine("You will see him get right to them soon!");
                Console.ReadLine();
                Console.WriteLine("Your reward is a soft warm hot chocolate, specially gifted from mobin");
                Console.ReadLine();
                Console.WriteLine("Lets get right back to the story...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Oh man, that wasn't close.");
                Console.ReadLine();
                Console.WriteLine("Its okay... maybe another time!");
                Console.ReadLine();
                Console.WriteLine("Lets go back to story shall we!");
                Console.ReadLine();
            }
        }


        // a mini user-oriented mission to find mobin's pet
        static void FindPet()
        {
            Console.WriteLine("Mobin heard a familiar noise from one of the drawers.");
            Console.ReadLine();
            Console.WriteLine("That is his bet, now by choosing correct intervals between 4 to 14 help him choose the right drawer.");
            Console.ReadLine();
            Console.WriteLine("He will go through them 1 time, you've got one number to give!!");
            Console.ReadLine();

            Console.WriteLine("Enter your number now! (*enter once begin*)");
            Console.ReadLine();

            int score = 0;

            //===========================
            // ATTEMPT 1
            //===========================
            bool attempt = int.TryParse(Console.ReadLine(), out int enteredNumber);

            if (attempt && enteredNumber >= 4 && enteredNumber <= 14)
            {
                int resultNumber = enteredNumber % 4;
                score += resultNumber;

                Console.WriteLine("Perfect, let's evaluate your choice.");
                Console.ReadLine();
                Console.WriteLine("Your chosen number is: " + enteredNumber);
                Console.WriteLine("Your score for this number: " + score);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aw that wasn't in range, we lost the pet voice, he will find his later, when there was a voice. again");
                Console.ReadLine();
                Console.WriteLine("*Getting back to the storyline...*");
                return;
            }

            if (score >= 1)
            {
                Console.WriteLine("Mobin found coco!!");
                Console.ReadLine();
                Console.WriteLine("And that is thanks to you!");
                Console.ReadLine();
                Console.WriteLine("Your reward is a delicious dinner with him!");
                Console.ReadLine();
                Console.WriteLine("Lets go to the story shall we?");
                Console.ReadLine();
            }
            else if (score <= 0)
            {
                Console.WriteLine("Oh no, your score was not sufficient, he wouldn't have to keep searching.");
                Console.ReadLine();
                Console.WriteLine("*Back to main storyline*");
                Console.ReadLine();
            }
        }


        //last part of the story is a simple commitment test
        //i admit its trivial and off, i felt tired of coding, i will compensate in next projects
        static void Commitment()
        {
            bool isMobinCommited = true;
            bool doesHehaveTime = true;

            if (isMobinCommited == true && doesHehaveTime == true)
            {
                Console.WriteLine("He can not let adversity get over him");
                Console.ReadLine();
                Console.WriteLine("He is feeling more disciplined than ever!!");
                Console.ReadLine();
                Console.WriteLine("And with that he has finished a long day of work.");
            }
            else
            {
                Console.WriteLine("Unfourtanetly, he couldn't do much about his fatgiue");
                Console.ReadLine();
                Console.WriteLine("He decided for a 5 minutes rest.");
                Console.ReadLine();
                Console.WriteLine("But...");
                Console.ReadLine();
                Console.WriteLine("The cleaning soon became next day's work.");
            }
        }
        static void Main(string[] args)
        {
            // this here is a special weekend combining everything i have learned throughout the week.
            // the rules are simple: every element i learned should be present, as for older week, only necessary ones, current week, everything.
            // A story about cleaning mobin's room.
            // It will be a text adventure full project
            //final review: i'll geniunely stop overusing Console.ReadLine(); , only for appropriate parts from now on 
            //there were parts where logic and math didn't meet, i will work on that, nontheless, this is all of my knowledge in a week.

            Console.WriteLine("Mobin to himself: i should get my room cleaned, best thing is to see what items i have here");
            Console.ReadLine();
            Console.WriteLine("Alright, just looking at the room i can count the items, let me log them.");
            Console.ReadLine();

            //declaring 4 additonal items to initiate a game for the user.
            float totalItems = 12F;
            double cash = 39.99F;
            decimal randomKeyboardKeys = 5.5M;
            int penHolders = 3;
            const long DRAWERS = 4;
            long plushies = 2;

            // i'll call a method here, (which i learnt ahead of my course), to let the user make a guess.
            Console.WriteLine("Among them all mobin have found several interesting iems...,");
            Console.ReadLine();
            Console.WriteLine("Can you guess how many were they?");
            Console.ReadLine();
            Console.WriteLine("You deserve a great reward if you do so... (hint: it is more than 3 and less than 7)");
            Console.ReadLine();
            GuessItem();

            // back to the main story
            Console.WriteLine("*Meanwhile mobin has been feeling troubled...*");
            Console.ReadLine();
            Console.WriteLine("Oh my god, it feels a lot to organize these many items");
            Console.ReadLine();
            Console.WriteLine("So if i clean 4 items every half an hour, how much will be left?");
            Console.ReadLine();
            Console.WriteLine("i I'll do some math then i guess.");
            Console.ReadLine();

            //initializing varaibles to do calculations
            float itemsLeft = totalItems % 4;
            float totalCleaningTime = (4 * 30 / 60);

            Console.WriteLine("Okay that will be " + itemsLeft + " left actually... wow awesome!");
            Console.ReadLine();
            Console.WriteLine("The time it takes is " + totalCleaningTime + " hours, i can spread it out through the day");
            Console.ReadLine();

            //using the four items mentioned earlier
            Console.WriteLine("Among everything all these 12 items, these 4 caught my attention");
            Console.ReadLine();
            Console.WriteLine("Some left over cash which was " + cash + "$" + " pretty interesting to say the least");
            Console.ReadLine();
            Console.WriteLine("And " + randomKeyboardKeys + " keyboard keys which i don't know its origin");
            Console.ReadLine();
            Console.WriteLine("The rest are " + penHolders + " pen holders, and " + plushies + " plushies");
            Console.ReadLine();

            //using boolean values here and decrementing (will declare a method for this cause)
            Console.WriteLine("I'll get them sorted out tonight");
            Console.ReadLine();
            Console.WriteLine("I'll start with my drawers.");
            Console.ReadLine();
            Console.WriteLine("He has " + DRAWERS + " drawers");
            Console.ReadLine();
            Console.WriteLine("*It was then that he panicked*");
            Console.ReadLine();
            Console.WriteLine("Among all his 12 items, mobin... has lost the most precious one,...");
            Console.ReadLine();
            Console.WriteLine("His pet coco.");
            Console.ReadLine();

            Console.WriteLine("And now if you help him find his pet, you will have a chance to win a great reward again!");
            Console.ReadLine();
            FindPet();

            Console.WriteLine("Finally mobin is about to finish his cleaning and call it a day");
            Console.ReadLine();
            Console.WriteLine("But his energy is dipping, wondering if has time or commitment to finish");
            Console.ReadLine();
            Console.WriteLine("Lets us find out...!");
            Console.ReadLine();
            Commitment();

            Console.WriteLine("And with that our story is over.");
            Console.ReadLine();
            Console.WriteLine("Thank you for your warm company");
            Console.ReadLine();
            Console.WriteLine("And i will see you!");
            Console.ReadLine();

        }
    }
}

