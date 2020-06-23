using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("default if no other case is excuted");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch(today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                        break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("sorry we are closed");
                        break;


            }
        }

    }
}
