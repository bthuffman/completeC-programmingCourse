using System;

// > Greater than
// < Less Than
// >= Greater than or Equal to
// <= Less than or Equal to
// == Equal to
// != Not equal to (different)

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        string name = "Tod";

        bool isTheFirstNumberLessThanSecondNumber = firstNumber < secondNumber;

        Console.WriteLine(isTheFirstNumberLessThanSecondNumber);
        Console.WriteLine(name.Length >= "bob".Length);
    }
}
