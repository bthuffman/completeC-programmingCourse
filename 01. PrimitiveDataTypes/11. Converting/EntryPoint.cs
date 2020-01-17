using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = null;
        char x = 'x';
        float pi = 3.99f;

        float integer = number;
        int floating = (int)pi;

        System.Console.WriteLine(integer);
        System.Console.WriteLine(floating);

        int convertedString = Convert.ToInt32(word);
        Console.WriteLine(convertedString);

        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);
    }
}