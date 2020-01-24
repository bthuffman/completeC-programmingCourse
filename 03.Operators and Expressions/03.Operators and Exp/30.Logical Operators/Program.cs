
using System;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
        //////////////////////////////////////////////////////////////////////////////////
        ///Logical operators
        // or, and, not, nor, and


        ////Or ||
        //Result true if one is true  
        //Result false if both are flase 

        //a false or true = true
        //a false or false = false


        ////And &&
        //Result is false of one is false 
        //Result is true if both are true 

        //a false and true = false
        //a true and true = true


        ////Not !
        //Returns the opposite

        //a false = true
        //a true = false


        ////Nor
        //Returns true if both false
        //Returns false if one is true

        //a false and a false = true
        //a true and a false = false

        ////NAnd
        //Returns true if one is false
        //Returns false if both are true

        //a true and false = true
        //a false and false = false


        //CHALLENGES

        //Must be longer than 6 characters 
        //OR
        //First character is a capital letter (this requires use of the ascii table

        string username = "prettyboy66";

        bool isStrLongerThan6 = username.Length >= 6;
        System.Console.WriteLine(isStrLongerThan6);

        //ASCII Decimal Representations of Capitalized Characters are from 65-90
        string s = "ABCD";
        int firstLetter = (int)s[0];
        Console.WriteLine(firstLetter);
        //65

        //in his example he typecasts username[0] to int. I.E. (int)username[0]
        bool isFirstLetterCapitalized = username[0] >= 65 && username[0] <= 90;
        System.Console.WriteLine(isFirstLetterCapitalized);

        System.Console.WriteLine(isStrLongerThan6 || isFirstLetterCapitalized);

        //should use variables as I did to seperate bools or use brackets to seperate smaller bool outcomes from the central one.
        //This will offset instances where the precedence of logical operators disrupts your logic flow
        //Precedent is set as:
        // &&
        // ||
        //Ex. nearly identical conditions, have different outcomes without brackets

        Console.WriteLine(true | true & false);   // output: True
        Console.WriteLine((true | true) & false); // output: False

        bool Operand(string name, bool value)
        {
            Console.WriteLine($"Operand {name} is evaluated.");
            return value;
        }

        var byDefaultPrecedence = Operand("A", true) || Operand("B", true) && Operand("C", false);
        Console.WriteLine(byDefaultPrecedence);
        // Output:
        // Operand A is evaluated.
        // True

        var changedOrder = (Operand("A", true) || Operand("B", true)) && Operand("C", false);
        Console.WriteLine(changedOrder);
        // Output:
        // Operand A is evaluated.
        // Operand C is evaluated.
        // False


        //////////////CHALLENGE 2
        ///Length of username must be 5 to 14 characters
        ///The first character is a small character which also implies it is not a number
        ///And it is not equal to "admin"

        Console.WriteLine("///////////////////////////////////////////Start of second Challenge");

        //Change this variable to mix up the results. 
        string newUsername = "Brandon";

        bool isRightLength = newUsername.Length >= 5 && newUsername.Length <= 14;
        Console.WriteLine(isRightLength);

        //ASCII values for int 48-57
        bool firstLetterIsNotANumber = !(newUsername[0] >= 48 && newUsername[0] <= 57);
        Console.WriteLine(firstLetterIsNotANumber);

        //ASCII values for uppercase letters is 65-90
        bool firstCharacterIsLowerCase = !(newUsername[0] >= 65 && newUsername[0] <= 90);
        Console.WriteLine(firstCharacterIsLowerCase);

        bool notEqualToAdmin = newUsername != "admin";
        Console.WriteLine(notEqualToAdmin);

        bool meetsConditions = isRightLength && firstLetterIsNotANumber && firstCharacterIsLowerCase && notEqualToAdmin;
        Console.WriteLine(meetsConditions);

        //////////////////////////////////////////////////////////////////////
        ///31. Ternary Operator - The most basic conditional statement

        // expression ? if true this result : if false this result;
        //Note the values returned must be of the same type as the variable to which they are going to be assigned. 

        var isRigged = false;

        string electionOutcome = isRigged ? "Time to leave the US!" : "It's a safe place for gays";
        Console.WriteLine("//////////////////////////////////////////////////////////////////////");
        Console.WriteLine(electionOutcome);
    }
}
