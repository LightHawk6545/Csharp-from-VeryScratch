using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mobin_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is my first exposure to numeric data types

            //In here i found declaring a patient's numeric information would be the best practice for me

            Console.WriteLine("WE HAVE NUMERIC TYPES FOLKS LETS GETS STARTEDD");
            Console.ReadLine();


            Console.WriteLine("first OF everything AND ALL we have a patient to register their data");
            Console.ReadLine();


            int age = 55;
            int temprature = -4;

            //i tried to make "int.MaxValue" memorable so i included it in the story 

            Console.WriteLine("Also by the patients last request we will include max and min amount of each type... yeah man get used to it");
            Console.WriteLine("Thats for int");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.ReadLine();


            Console.WriteLine("Alr lets get started with age:");
            Console.WriteLine(age);
            Console.ReadLine();


            Console.WriteLine("Temprature when they passed to heavens: ");
            Console.WriteLine(temprature);
            Console.ReadLine();


            float money = 89.7676F;
            double hair_grown = 88765333342424231.1111D;

            Console.WriteLine("Money held in hand at time of death (also a bottle of beer but we don't talk about that): ");
            Console.WriteLine(money);
            Console.ReadLine();

            //trying out variables with decimals, feel free to try some in my code.

            Console.WriteLine("Also the poor man did something a little off by the way we will include...");
            Console.WriteLine("Number of indiviual hair grown and given to charity....:  (yeah.)");
            Console.WriteLine(hair_grown);
            Console.ReadLine();


            decimal beer_liters = 5556.93937M;

            Console.WriteLine("Amount of beer went down his guts (in precise liters): ");
            Console.WriteLine(beer_liters);
            Console.ReadLine();

            Console.WriteLine("yeah that's it see ya");
            Console.ReadLine();

            Console.WriteLine("also side note you call a variable like this: ");
            Console.ReadLine();

            //you can also declare them like this so i gave it a go.
            int x, y, z;

            Console.WriteLine("or ");
            Console.ReadLine();

            int x1,
                y2,
                z3;

            Console.WriteLine("i can see it, you cant, xd");
            Console.ReadLine();

            Console.WriteLine("i didn't forget this btw");
            Console.ReadLine();

            Console.WriteLine("Hey Double max and min:");
            Console.WriteLine(Double.MaxValue);
            Console.WriteLine(Double.MinValue);
            Console.ReadLine();

            Console.WriteLine("For float: ");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.ReadLine();

            Console.WriteLine("Finally for decimal: ");
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.ReadLine();
        }
    }
}
