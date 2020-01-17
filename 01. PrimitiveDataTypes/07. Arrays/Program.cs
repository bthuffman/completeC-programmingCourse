using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        numbers[0] = 6;
        numbers[1] = 5;
        numbers[2] = 100;
        numbers[3] = 66;
        numbers[4] = 71;

        Console.WriteLine(numbers[2]);

        numbers[2] = 50;

        Console.WriteLine(numbers[2]);
        
        string[] fruits = { "oranges", "bananas", "strawberries", "lemons", "tomatoes" };
        string[] fruitsV2 = new string[5];

        fruitsV2[0] = "oranges";
        fruitsV2[1] = "bananas";
        fruitsV2[2] = "strawberries";
        fruitsV2[3] = "lemons";
        fruitsV2[4] = "tomatoes";

        Console.WriteLine(fruitsV2[2]);

        fruitsV2[2] = "kiwis";
        Console.WriteLine(fruitsV2[2]);

    }
}