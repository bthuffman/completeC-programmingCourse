
    class Program
    {
        static void Main()
        {
        //make a int an array
        int[] numbers = { 5, 6, 2, 5, 6 };

        System.Console.WriteLine(numbers[3]);
        //5

        //more commonly will create them like this
        //this array will have 5 values (all 0's)
        int[] moreNumbers = new int[5];

        System.Console.WriteLine(moreNumbers[2]);

        moreNumbers[2] = 3;
        System.Console.WriteLine(moreNumbers[2]);

        string[] stringArray = new string[5];

        System.Console.WriteLine(stringArray[0]);

        stringArray[0] = "Winter";

        System.Console.WriteLine(stringArray[0]);

        string[] democracy = { "Freedom of Speach", "Emancipation", "Free Market", "Democratic Elections" };

        int count = 0;
        foreach (string element in democracy)
        {
            count++;
            System.Console.WriteLine($"Element #{count}: {element}");
        }

        //getting index of a character in a word that is within an array
        System.Console.WriteLine(democracy[0][2]);
        }
    }
