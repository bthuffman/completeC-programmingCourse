
using System;
using System.Text;

class EntryPoint
    {
        static void Main()
        {
        //Character type is for special characters or to just to assign var to a single character (can only be a single char)
        char characterX = 'x';

        System.Console.WriteLine(characterX);

        //special chars can be written with \u#### with the #### being the ascii table identifying number 
        //http://www.asciitable.com/
        char plusSymbol = '\u002b';

        System.Console.WriteLine(plusSymbol);

        //unicode table behaves similarly, far more options.
        //https://unicode-table.com/en/

        char lambda = '\u03BB';

        System.Console.WriteLine(lambda);

        //frequently the results depend on the console setting so you may need to adjust them with this
        //Changes the input and output encoding for the console, gives it more capabilities
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        char lambda2 = '\u03BB';

        System.Console.WriteLine(lambda2);

        ////////////////////////////////////////////////////
        ///Strings
        string username = "admin";

        //what first letter of string
        Console.WriteLine(username[0]);

        //try to change the character at a certain index
        //won't work, strings are immutable! 
        //username[4] = "d";
    }
}
