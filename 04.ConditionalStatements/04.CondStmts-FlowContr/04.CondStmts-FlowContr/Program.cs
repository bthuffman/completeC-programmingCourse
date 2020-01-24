using System;

class Program
{
    static void Main(string[] args)
    {
        //if and else statements exactly as you would expect

        /////////////////////////////////////////////////////
        ///

       // int number = Convert.ToInt32(Console.ReadLine());

        //string result = number % 2 == 0 && number % 3 == 0 && number % 4 == 0 ? "It is divisible by 2, 3, and 4" : "It is not divisible by 2, 3, and 4";

       // Console.WriteLine(result);

        //cannot access integers indexes, have to turn them into strings (ToString())

        /////////////////////////////////////////////////////////
        ///The "else if" conditional statement - adding more conditions
        ///

        //Note that you can have conditions in which numbers are equal and the if block output's results incorrectly or not as desired.
        //These circumstances require you create an else if block for such instances. 

        /////////////////////////////////////////////////////////
        ///Practicing the "else if" conditional statement
        ///

        //Expression checks if coordinates lie within the radius of a circle
        //Cicle center 0,0 with a radius of 4 meaning that the circumference is...

        //MY OG METHOD 
        //WRONG

        double PI = 3.14159265358979;
        int x = -4;
        int y = -4;

        //double circumference = PI*4*4;

        int radius = 4;

        //Console.WriteLine(circumference);

        //if (x <= 4 && x >= -4 && y <= 4 && y >= -4)
       // {
       //     Console.WriteLine("Coordinates lie within the radius of the circle");
        //}
       // else
       // {
        //    Console.WriteLine("Coordinates do not lie within the radius of the circle");
      //  }

        //instructors method
        //the distance from the center of the circle given x & y coordinates 
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        if (distance == radius)
        {
            Console.WriteLine($"The distance to the point is {distance}, and it is exactly on the border of the circle!");
        }
        else if (distance < radius)
        {
            Console.WriteLine($"The distance to the point is {distance}, and it is inside the circle");
        }
        else if (distance > radius)
        {
            Console.WriteLine($"The distance to the point is {distance}, and it is inside the circle");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}