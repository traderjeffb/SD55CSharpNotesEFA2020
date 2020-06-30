using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_variables_and_valueTypes
{ //use enums if you have static values. something you don't anticipate changing. note-Pascal casing. 
    enum Pastrytype { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish }
    class Program
    {
        static void Main(string[] args)
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            char character = 'a'; //use single quotes for a character. Double quotes are for strings. 
            char symbol = '&';
            char number = '5';
            char space = ' '; //can be a symbol, number or even a space 
            char specialCharacter = 'n';//or even a special character

            //Whole Numbers
            byte byteExample = 255; //max numbe is 256
            sbyte sByteExample = -128; //
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            UInt32 intMax = 2147483648;
            long longExample = 9223372036854775807;
            Int64 longMin = 9223372036854775807;//same as above 
            
            //below was used for breakpoint practice
            int a = 7;
            int b = -7000;

            byte age = 164;
            //--------------------------------

            //Decimals
            float floatExample = 1045231f;//f makes this a float
            double doubleExample = 178905278907036d;

            //if you look at the print out of the below numbers it show the cutoff points of the different types
            Console.WriteLine(1.8181581691651616416f);
            Console.WriteLine(1.8181581691651616416d);
            Console.WriteLine(1.8181581691651616416m);
            Console.ReadLine();

            //Enums DECLAIRED outside the class-see top of this page.use enums if you have static values- something you don't anticipate changing. note-Pascal casing. 
            Pastrytype myPastry = Pastrytype.Croissant;
            Pastrytype anotherOne = Pastrytype.Donut;

            //Structs -have default values
            Int32 potato = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805, 11, 24);
            DateTime test = new DateTime();






        }
    }
}
