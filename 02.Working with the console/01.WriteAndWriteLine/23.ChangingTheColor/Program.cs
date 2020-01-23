using System;

    class Program
    {
        static void Main()
        {
        //change text color to blue
        //if you highlight over ForegroundColor you will notice it displays the ConsoleColor to which assign right. This is called an amoration. More detail ltr.
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Red;

        Console.WriteLine("A turtle made it to the water.");
        Console.WriteLine("I've collected many things over the years.");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("The cycle of life can be cruel.");


        //Use console.write method to color specific words in a line
        Console.Write("The ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(" End");

        //reset colors to default
        Console.ResetColor();

        //////////////////////////////////////////////////////////////////////////
        ///Changing cursor settings in Console - Size, Visibility and Position
        //can Title the Console window that pops up
        Console.Title = "My App";

        //Disable cursor (invisible)
        //Console.CursorVisible = false;

        //defualt
        //Console.CursorVisible = true;

        //Adjust the console size
        Console.CursorSize = 100;

        //change the cursor position. How much free space to the left (in characters) and then how much free space on top above cursor 
        //(in rows). Therefore a row is bigger than a char (about 2x)
        Console.SetCursorPosition(30,15);

        //Move cursor just horizontally
        Console.CursorLeft = 50;
        //Move the cursor vertically only
        Console.CursorTop = 25;

        ///////////////////////////////////////////////////////////////////////////
        ///Controlling size of console window - size, buffer size and more

        ///////////////Viewable size of console...
        //Console.WindowHeight = 20;
        //Console.WindowWidth = 20;

        //Alternative
        Console.SetWindowSize(20, 20);

        //////////////Buffer size, how much can you scroll outsdie of your visible console space (actual size of the console) Must be > WindowSize
        //Console.BufferHeight = 20;
        //Console.BufferWidth = 20;

        Console.SetBufferSize(20, 20);

        //For both SetWindowSize and SetBufferSize you can set them to the LargestWindowWidth/Height 
        //Ex (Console.LargestWindowWidth, Console.LargestWindowHeight) inside of the int spots and will fill you're screen. 
        //Not Buffer size must be greater than or equal to the window size.

        ////////////////Note that these really control where in the window you are viewing (camera position). If your buffer is not bigger than the window by at 
        //least the amount you specify here then it will throw an exception.
        Console.SetWindowPosition(10, 10);
    }
}
