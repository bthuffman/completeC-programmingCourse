using System;


class EntryPoint
{
    static void Main()
    {
        // expression ? true side : false side;
        string incomingTemporaryUsername = "prettyboy66";

        string username = incomingTemporaryUsername.Length > 6 ? incomingTemporaryUsername : "default_user";

        ConsoleColor color = incomingTemporaryUsername.Length > 6 ? ConsoleColor.Green : ConsoleColor.Red;

        Console.ForegroundColor = color;
        Console.WriteLine(username);
        Console.ResetColor();
    }
}