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
            // In this session i'll be exploring const keyword, with additional exercises


            Console.WriteLine("Dang it be hot today , i feel like i could use a drink");
            Console.ReadLine();

            const string Card_Pin = "0040";

            Console.WriteLine("what is the pin of this card, should call mobin real quick for that");
            Console.ReadLine();


            const string Mobin_Number = "002200000";
            Console.WriteLine("Alright dialing him real quick the number should be " + Mobin_Number + " , okay its ringing");
            Console.ReadLine();


            Console.WriteLine("Mobin: Oh hello, ...  ");
            Console.ReadLine();


            Console.WriteLine("Mobin what's the pin to this?");
            Console.ReadLine();


            Console.WriteLine("it is " + Card_Pin);
            Console.ReadLine();


            Console.WriteLine("Alright! thank you. see you!");
            Console.ReadLine();


            int drink_price = 10;
            int gas = 20;
            int wallet = 150;


            Console.WriteLine("Okay " + drink_price + "$" + " is not bad for 4 drinks, 2 for me, 2 mobin's, cheers");
            Console.ReadLine();

            wallet -= drink_price;

            Console.WriteLine("That's " + wallet + "$" + " left.");

            Console.WriteLine("The rest is for gas, i doubt anything will remain in my wallet");
            Console.ReadLine();


            Console.WriteLine("The gas is " + gas + "$" + " per liter, normal.");
            Console.ReadLine();


            wallet = wallet % gas;


            Console.WriteLine("Alright lets see " + wallet + "$" + " Finally, went bankrupt, a clean even number tho");
            Console.ReadLine();


            Console.WriteLine("Should go home now anyways, see you!");
            Console.ReadLine();



        }
    }
}
