using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mobin_learning
{
    internal class Program
    {
        private static object coco;

        static void Main(string[] args)
        {
            // dedication to practice remainder and var keyword


            Console.WriteLine("Hey coco, lets go for a walk");
            Console.WriteLine("*coco is mobin's pet*");
            Console.ReadLine();


            Console.WriteLine("how come after so long?, said coco");
            Console.ReadLine();


            Console.WriteLine("mobin: im in my creation mode so why not we'll play with some fun stuff");
            Console.ReadLine();

            Console.WriteLine("so coco i've been counting it takes 1000 steps to get to the nearest pet shop which is 5 minutes");
            Console.ReadLine();


            Console.WriteLine("Do you think by then we would have stepped over 100 or less in exactly 5 minutes?");
            Console.ReadLine();


            Console.WriteLine("coco: good grief, not him starting with calculations,... i mean it has rough calculations i don't recall");
            Console.ReadLine();


            int steps = 1000;
            int time = 5;
            int Walked_More_Or_Less = steps % time;



            Console.WriteLine("Its pretty easy you just have to take the remainder when dividing these 2, its... "
                + Walked_More_Or_Less +
                " beacuse we fill every minute with 200 steps");
            Console.ReadLine();


            Console.WriteLine("That's some good use of remainder mobin");
            Console.ReadLine();


            Console.WriteLine("What's with your silence tho?");
            Console.ReadLine();

            Console.WriteLine("mobin: im letting my brain proccess things like when you let a compiler decide a datatype using var keyword, see");
            Console.ReadLine();


            var name = "coco";
            var Is_Cold = true;

            Console.WriteLine(name + " is cold: " + Is_Cold);
            Console.ReadLine();


            Console.WriteLine("see i didn't even bother decalring");
            Console.ReadLine();


            Console.WriteLine(" but it has limitations, you should only use it for obvious cases that cannot be mistaken for anything else");
            Console.ReadLine();


            Console.WriteLine("like age, height, Not... a variable named Big Number or Money these constantly" +
                " change and we may need different datatypes for them depending on the situation coco");
            Console.ReadLine();


            Console.WriteLine("mobin just let me walk peacefully, thank you tho... its that...");
            Console.ReadLine();

            s
            Console.WriteLine("My Brain Short - circuited");
            Console.ReadLine();


            Console.WriteLine("My bad coco, lets go then");
            Console.ReadLine();

        }
    }
}

