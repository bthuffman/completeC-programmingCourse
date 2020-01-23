using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int thirdNumber = 15;

        int addition = firstNumber + secondNumber;
        int subtraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)firstNumber / (double)secondNumber;

        Console.WriteLine(addition);
        Console.WriteLine(subtraction);
        Console.WriteLine(multiplication);
        Console.WriteLine(division);

        int equation = firstNumber * (secondNumber - thirdNumber);

        Console.WriteLine(equation);

        double equation2 = ((3 / 7) + Math.Pow(5, 2)) / (3 + (4 / 3));

        Console.WriteLine(equation2);

        // ++, --
        Console.WriteLine(firstNumber);
        firstNumber++;
        firstNumber++;
        firstNumber--;
        //firstNumber = firstNumber - 1;
        Console.WriteLine(firstNumber);

        long remainder = 4573648743 % 2;
        Console.WriteLine(remainder);
    }
}