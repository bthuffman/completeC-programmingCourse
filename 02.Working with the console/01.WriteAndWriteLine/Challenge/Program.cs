using System;

class Program
{
    static void Main()
    {
        string verticalSep = "|";
        string title = "THE BEST CHOICES";
        string hroizontalSep = new string('=', title.Length + 2);

        System.Console.Write(verticalSep + "The Best Choices" + verticalSep + "\n");
        System.Console.WriteLine(" Health \n Joy \n Relationships \n Family \n Environment");

        System.Console.WriteLine($"{verticalSep} Health{verticalSep} " +
            $"\n{verticalSep} Joy{verticalSep} " +
            $"\n{verticalSep} Relationships{verticalSep} " +
            $"\n{verticalSep} Family{verticalSep} " +
            $"\n{verticalSep} Environment{verticalSep} " +
            $"\n{hroizontalSep}");

        string one = "Health";
        string two = "Joy";
        string three = "Relationships";

        System.Console.WriteLine($"{verticalSep} {one, 15}{verticalSep} " +
    $"\n{verticalSep} {two, 15}{verticalSep} " +
    $"\n{verticalSep} {three, 15}{verticalSep} ");

        //SUMMARY
        //{ 0, 10} to move 10 chars to the right with placeholders

        //{ varName, 10} to move 10 chars to the right with interpolation

        //{ 0/varName, 10:C5} to move and add currency rounding of 5 digits

        //{ 0/varName:C5} to add currency rounding of 5 digits

        ////////////////////////////////////////////////////////////////////////////////////
        ///Accepting Single Character Inputs from the Console Read Method
        ///
        Console.WriteLine("How old are you? ");
            
        //int value = Console.Read(); //enter 15
        //Console.WriteLine($"My age is {value}");
        //returns age of 49 because of the ascii table. The character 1 gives you the output 49

        //therefore this sb a character and save it into a char variable. Char and int are compatible so can directly type cast them as long as the integer has character representation.
        //The read method is only reading the first character, so not quite what we want
        //char age = (char)Console.Read(); //enter 15
        //Console.WriteLine($"My age is {age}");
        //returns 1 if only Console.Read else if 2nd Console.Read then 1. 

        ////////////////////////////////////////////////////////////////////////////////////
        //Accepting string inputs from the Console - readline method
        //ReadLine returns strings instead of a single character
        //string age2 = Console.ReadLine(); //enter 15
        //Console.WriteLine($"My age is {age2}");
        //returns 15

        //convert or parse string so can use input as an interger (cannot typecast to integer)

        //parse
        int age3 = int.Parse(Console.ReadLine()); //enter fifteen and won't work. It will only work if use numbers
        Console.WriteLine($"My age is {age3 + 1}");

        //To get a chance for a second input you should use Console.ReadLine or to move the Console.Read method to be last. 

        int age4 = int.Parse(Console.ReadLine());
        Console.WriteLine($"My age is {age4 + 1}");


        //SUMMARY Readline reads a sequence of chars (str). 
        //use int.Parse or Convert.ToInt32 to turn str into int
        //Caution for using Read, should use ReadLine

        ////////////////////////////////////////////////////////////////////////////////////
        ///Accepting Inputs as Keys from the Console - ReadKey
        
        //ReadKey's are custom datatypes, not string or character
        ConsoleKeyInfo key = Console.ReadKey();

        //This will return the namespace of and the datatype of key. 
        Console.WriteLine(key);

        //To see what key was pressed use key.Key
        Console.WriteLine(key.Key);


        //Read will be activated after you click enter. Whereas ReadKey is being activated as soon as you press the key. 
        ConsoleKeyInfo key1 = Console.ReadKey();

        //to obtain actual character with case sensitivity then use key.KeyChar
        Console.WriteLine(key1.KeyChar);

        //save key as char if want to. 

        //Key modifiers, will show the modifiers being uses with the corresponding key. This will display in a predefined order rather than the order in which you pressed them.
        Console.WriteLine(key1.Modifiers);


    }
}
