using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operators_and_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////To do addition between two numbers neither can be a string
            int first = 10;
            int second = 20;

            //adds
            int addition = first + second;
            Console.WriteLine(addition);
            //concatenates
            Console.WriteLine(first.ToString() + second);
            /////////////////Sub and multiplication is st8 fwd

            ////////////////To get division with decimals
            //Cannot save the result of division into an int unless the result is a whole number
            int division = first / second;
            //use double and use floating numbers instead of ints
            //you could type cast the original ints into doubles. Cannot be saved into an integer then. 
            double divisionAgain = (double)first/(double)second;

            Console.WriteLine(division);
            Console.WriteLine(divisionAgain);

            //For problems involving orders of operations you must enforce them, the program first. 
            //example [(3/7) + 5^2 ]/[3 + (4/3)] Should set result = double and should assign each value to a double variable or they will act as ints

            //this will result in 6.25 when should be 5.86813186813187 
            double equation = ((3 / 7)  +Math.Pow(5,2)) / (3 + (4 / 3));
            Console.WriteLine(equation);

            //Returns 5.86813186813187
            double equationTwo = ((3d / 7d) + Math.Pow(5, 2)) / (3d + (4d / 3d));
            Console.WriteLine(equationTwo);

            //This also returns 5.86813186813187
            double equationThree = ((3.0 / 7.0) + Math.Pow(5, 2)) / (3.0 + (4.0 / 3.0));
            Console.WriteLine(equationThree);

            // ++ & -- operators do what you would expect. 
            first++;
            //is the same as
            first = first + 1;
            Console.WriteLine(first);

            //% remainder operator does what you'd expect. 

            //////////////////////////////////////////////////////////////////////////////////
            ///Assignment Operators - just a shortcut for arithmetic operators
            //= is an assignment operator

            // short hand operators
            // += -= *= /= %=
            first += second;
            //same as 
            first = first + second;

            //////////////////////////////////////////////////////////////////////////////////
            ///Comparison operators
            // <, >, ==, !=

            //booleans are the result. 
            Console.WriteLine(2 > 3);
            Console.WriteLine(2 < 3);
            Console.WriteLine("Tod" == "tod");
            Console.WriteLine("Tod".Length == "tod".Length);

            //Use boolean variables for conditionals. 
            bool right = 2 < 3;
            Console.WriteLine(right);

            
        }
    }
}
