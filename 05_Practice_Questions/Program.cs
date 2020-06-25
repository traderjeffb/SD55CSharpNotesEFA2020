using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_Practice_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 1.24681681135f;
            decimal myDecimal = 1.22m;
            double myDouble = 22.6512562d;
            int myInt = 55;
            string myString = "Joe";
            bool myBool = true;
            //Console.WriteLine(myBool, myDecimal, myDouble, myFloat, myInt, myString);

            //2. Welcome message
            Console.WriteLine($"Welcome to the show: {myString}");
            Console.WriteLine($"{myString} You have just won $1,000,000 from the Royal Prince of Bevistan!!!! ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"This weeks daily double winner is: {myString}");
            Console.ResetColor();


            string cheese = "stringy cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";
            //interpolation
            string InterpolatedSideDishItems = $"{cheese} {pasta} {beans}";
            Console.WriteLine("Tonights side dishes include: ");
            Console.WriteLine(InterpolatedSideDishItems);
            //composite to form a string
            string compositeSideDishes = string.Format("I think {0} tastes the best and {1} makes me fat, worse yet, {2} makes me fart", cheese, pasta, beans);
            Console.WriteLine(compositeSideDishes);

            string myvariable = "Hello";
            string compositeHello = string.Format("{0} World and {0} Class! Welcome to Gold Badge!", myvariable);
            //composite, interpolation and concatinate
            Console.WriteLine(compositeHello);
            string interpolationHello = $"{myvariable} World and {myvariable} Class. Welcome to Gold Badge!!";
            Console.WriteLine(interpolationHello);
            Console.WriteLine(myvariable + " World and " + myvariable + " Class! Welcome to Gold Badge!!!");

            //for this one goes here----------

            int a = 42;
            int b = 5;
            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
            Console.WriteLine((5 % 42) + 3);

            //Operators
            int day = 24;
            bool testComparison1 = day > 1 && day < 30;//assigns value true
            bool testComparison2 = day > 15;//assigns value true
            bool testComparison3 = day < 1 || day > 100; //assigns the falue false
            bool testComparison4 = day < -1;//assigns the falue false
            Console.WriteLine(testComparison1);
            Console.WriteLine(testComparison2);
            Console.WriteLine(testComparison3);
            Console.WriteLine(testComparison4);

            //Conditionals
            int sleep = 55;
            if (sleep < 8)
            {
                Console.WriteLine("I am tired");
            }
            else
                if (sleep > 20)
            {
                Console.WriteLine("I might be in a coma");
            }


            bool isCarOn = false;
            bool carHasGas = false;
            if (carHasGas && isCarOn)
            {
                Console.WriteLine("let the adventure begin");
            }
            else if ((carHasGas = false) || (isCarOn = false));
            Console.WriteLine("Turns out I didn't get gas");


            string hogwartsHouse = "Harry";

            switch(hogwartsHouse)
            {
                case "Sam":
                 Console.WriteLine("You're not Harry!");
                     break;
                case "Hermidy":
                    Console.WriteLine("You're not Potter!");
                    break;
                case "Harry":
                    Console.WriteLine("I'm back!");
                    break;
                defalut: 
                    Console.WriteLine("I'm not Harry!");
                    break;
            }

            int volumeLevel = 4;
            string hearing = (volumeLevel >= 8) ? "Turn it down!" : "turn it up!";

            bool canSee = true;
            string outcome = (canSee) ? "keep lights off" : "turn on the lights";

            int i = 0;

            while ( i < 51)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i = i++;
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }
    } 


}
