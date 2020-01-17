using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        char theCharacterX = 'x';
        System.Console.WriteLine(theCharacterX);

        char thePlusSign = '\u00F6';

        System.Console.WriteLine(thePlusSign);
    }
}
