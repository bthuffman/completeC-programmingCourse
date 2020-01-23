using System;

// && - AND
// || - OR
// ! - NOT

class EntryPoint
{
    static void Main()
    {
        int number = 15;
        bool lessThan = number < 20;
        bool moreThan = number > 5;

        number = 25;

        lessThan = number < 20;
        moreThan = number > 5;

        bool isNotInRange = !(lessThan && moreThan);

        Console.WriteLine(lessThan);
        Console.WriteLine(moreThan);
        Console.WriteLine(isNotInRange);

        string username = "dre";

        // Longer than 6 characters
        // OR the first character is a capital character
        // integer representaion of the first character 

        bool usernameConditions = (username.Length > 6) || ((int)username[0] >= 65 && (int)username[0] <= 90);

        Console.WriteLine(usernameConditions);

        // length of the username is 5 to 14 and its first character is a small character and its not equal to "admin"
        // range is now 6 to 14, first character not a number

        bool usernameConditionsV2 = ((username.Length >= 5 && username.Length <= 14) && ((int)username[0] >= 65 && (int)username[0] <= 90) && (username != "admin")) || 
            ((username.Length >= 6 && username.Length <= 14) && !((int)username[0] >= 48 && (int)username[0] <= 57));

    }
}