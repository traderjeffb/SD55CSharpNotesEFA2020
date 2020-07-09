using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings
            string declared;
            declared = "This is insitialized";

            string declarationAndInitialization = "This is both declaring and initialzing.";

            Console.WriteLine("What is your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            //Concatenation
            string concatenatiedFullName = firstName + " " + lastName; 
            //Composite
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            //interpolation
            string InterpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatiedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(InterpolatedFullName);
            Console.ReadLine();

            //--Collections
            //Array --once you make an array it has a specific amount of space you cannot change it.
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            //--Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("First string of our lists");
            listOfIntegers.Add(4242);
            listOfIntegers.Add(12345);
            Console.WriteLine(listOfIntegers[0]);

            //--Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            //--Dictionaries has a key and value pair
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //--other collection Examples
            SortedList<int, string> SortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes must be instanciated with "new" keyword
            Random rng = new Random(); //Tic-Tac-Toe myNewInstanceOfAClass = new Tic_Tac-Toe
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);


            Console.ReadKey();
        }
    }
}
