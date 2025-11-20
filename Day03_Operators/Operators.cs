using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobin_learning
{
    internal class Program
    {
        private static object coco;

        static void Main(string[] args)
        {
            // This section is dedicated to operators practice and all kind of them
            // with a side of story...


            Console.WriteLine("hey mobin get me grocery receipt");
            Console.ReadLine();


            Console.WriteLine("i need to track the expenses");
            Console.ReadLine();


            Console.WriteLine("Alright man");
            Console.ReadLine();


            double receipt = 177.55;


            Console.WriteLine("bro... we over paid 1$, what in scam is this.. *shoves the receipt in mobin's face " + receipt + "$");
            Console.ReadLine();


            receipt--;


            Console.WriteLine("Mobin: ");
            Console.WriteLine("there you go, you damn broke " + receipt + "$" + " That's pathetic man");
            Console.ReadLine();


            int Monthly_cost = 1900;


            Console.WriteLine("and this is my monthly expense, " + Monthly_cost + "$" + ", so you don't feel bad");
            Console.ReadLine();

            // this method of adding is inefficient in the long run.
            Monthly_cost = Monthly_cost + 22;


            string More_Roast = "Oh by the way i even missed a few digits ";
            More_Roast += "Here it is " + Monthly_cost + "$";


            Console.WriteLine(More_Roast);
            Console.ReadLine();


            Console.WriteLine("NOW combine 12 month and never talk to me about some stupid 176$ ");
            Console.ReadLine();


            //however this method is super efficient
            Monthly_cost *= 12;


            Console.WriteLine("Oh man i wish you didn't do... for your own good tho.");
            Console.ReadLine();


            Console.WriteLine("anyways it is as you see " + Monthly_cost + "$");
            Console.ReadLine();


            Console.WriteLine("well this all aside i learnt in coding when you do i++, its a different thing than ++i");
            Console.ReadLine();

            Console.WriteLine("See... i'll set i as 52...");
            int i = 52;

            Console.WriteLine(i++);
            Console.ReadLine();

            --i;

            Console.WriteLine("Still the same because it is like when you cover a basket and try to add an apple afterward");
            Console.WriteLine("same thing happens with compiler it prints i and then adds it so... look at i again");
            Console.ReadLine();


            Console.WriteLine(++i);
            Console.ReadLine();

            Console.WriteLine("Now it worked because the basket was open and apple was added");
            Console.ReadLine();


            //note: best thing to do when dividing is not to use integers, it gives whole number
            //double, float and decimals do the job better
            // adding 2 character as in "char" data type will add their unicode and give some other unicode, so it wouldn't be 'a' + 'b' = 'ab', no.
        }
    }
}

