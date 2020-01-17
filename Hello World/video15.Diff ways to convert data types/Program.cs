
using System;

class Program
{
    static void Main()
    {
        int number = 5;
        string word = "5";
        string wordNull = null;
        char x = 'x';
        float pi = 3.14f;
https://www.udemy.com/course/the-complete-csharp-programming-course/
        float integer = number;


        //since this is a float then get an error
        //int floating = pi;

        //can if you type cast it
        //cannot save decimal in a int, it would round to the nearest integer
        int floater = (int)pi;

        System.Console.WriteLine(integer);
        System.Console.WriteLine(floater);

        //convert string to int. These two methods will work
        int stringedInteger = Convert.ToInt32(word);
        System.Console.WriteLine(stringedInteger);

        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);

        //convert null string to int
        int stringedInteger2 = Convert.ToInt32(wordNull);
        System.Console.WriteLine(stringedInteger2);

        //this cannot do null, it will give exception
        int parsedString2 = int.Parse(wordNull);
        Console.WriteLine(parsedString2);

        //TYPECASTING: using the datatype within brackets in front of the value you want typecasted. They must be compatible types

        //CONVERTING: return a zero if null

        //PARSING: returns exception if null 
    }
}
