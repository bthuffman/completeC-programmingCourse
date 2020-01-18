using System;

class Program
{
    static void Main()
    {
        //Console.Write keeps the console on the same line. As you already know WriteLine moves the corresponding 'dialogue' to the next line. 
        Console.Write("These share the same...");
        Console.Write("Line. ");

        // \n new line
        Console.Write("Let's move it to the next line by using \n");

        Console.WriteLine("The emergency system is now activated \n");

        Console.Write("Include \n override \n code \n");

        //if you click enter before the \n then it will automatically add "" and +
        Console.Write("Include " +
            "\n override " +
            "\n code \n");

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //OUTPUTTING SPECIAL CHARACTERS IN THE CONSOLE
        Console.WriteLine("///////////////////////////////////////////////////////////////////////////");


        string exeFile = "Word.exe";

        //this won't work because need to excape the escape lines
        //string pathToExe = "C:\Program Files\Microsft Word\";

        //This will work
        string pathToExe = "C:\\Program Files\\Microsft Word\\";

        Console.WriteLine(pathToExe + exeFile);

        //Want to have "" then use escape characters
        string pathToExe2 = "\"C:\\Program Files\\Microsft Word\\\"";

        Console.WriteLine(pathToExe2 + exeFile);

        //EASIEST way to do all this excaping is using the @ symbol. However with quotation marks you need double to escape them
        //cannot use \n with these
        string pathToExe3 = @"""C:\Program Files\Microsft Word\""";

        Console.WriteLine(pathToExe3 + exeFile);

        //given this make a proper write line with @ and without. 
        //Console.WriteLine("C:\Program Files\Microsft Programs"\'VisualStudio'");

        Console.WriteLine(@"""C:\Program Files\Microsft Programs""\'VisualStudio'""");

        Console.WriteLine("\"C:\\Program Files\\Microsft Programs\"\\'VisualStudio'\"");

        //STRING INTERPOLATION, use escape character for curly brackets. Curly bracket's are exscaped with themselves.
        Console.WriteLine($"{{{ pathToExe + "}"}{ exeFile}}}");
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //FORMATTING YOUR CONSOLE OUTPUTS - ALIGNMENTS, CURRENCY, DECIMAL POINT AND MORE
        Console.WriteLine("///////////////////////////////////////////////////////////////////////////");


        //leading spaces for aligning outputs to the right. 
        string fruit = "strawberry";
        string juice = "juice";

        Console.WriteLine(fruit +"\n" + juice);

        //Use placeholders to indent right. This is saying that the last character of the strings should be on the tenth place. Each character 
        //takes up two places which is why strawberry will not appear to move
        Console.WriteLine("{0, 10}",fruit);
        Console.WriteLine("{0, 10}", juice);

        //This will move it, but won't achieve alignment. 
        Console.WriteLine("{0, 15}", fruit);
        Console.WriteLine("{0, 15}", juice);

        //interpolation, same result
        Console.WriteLine($"{fruit,15}");
        Console.WriteLine($"{juice,15}");

        //can format things in a particular way
        //currency
        float dollarSigns = 10000.5446f;

        //the $ will be all the way left. Will round
        Console.WriteLine($"${dollarSigns, 15}");

        //to keep it together use a format specifier (C for currency, adds decimals and $). Will round
        Console.WriteLine($"{dollarSigns,15:C}");

        //add this to get more decimals
        Console.WriteLine($"{dollarSigns,15:C5}");

        //however since it is the float datatype it can only show 7 characters, thus need double

        double dollarSigns2 = 10000.5446f;
        Console.WriteLine($"{dollarSigns2,15:C5}");

        //also 
        Console.WriteLine("{0, 15:C5}", dollarSigns2);

        //another format specifier is N, fo rjust numbers. 
        Console.WriteLine("${0, 15:N5}", dollarSigns2);

        //can also use many of these things seperately
        Console.WriteLine($"{dollarSigns2:C5}");

        Console.WriteLine($"{dollarSigns2:C5}");

        Console.WriteLine("{0:N5}", dollarSigns2);


    }
}
