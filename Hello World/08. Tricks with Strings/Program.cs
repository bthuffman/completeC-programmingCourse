
    class Program
    {
        static void Main(string[] args)
        {
        string fruitJuice = "Strawberry Juice";

        //this will return true
        //it is case sensitive so if it was capital R then it would be false. 
        //does not return the number of r's found. 
        System.Console.WriteLine(fruitJuice.Contains("r"));

        //this will return the first index location of an occurence. If none it will return -1.
        System.Console.WriteLine(fruitJuice.IndexOf("r"));

        //this will return the last index instance of the char
        System.Console.WriteLine(fruitJuice.LastIndexOf("r"));

        //returns true
        System.Console.WriteLine(fruitJuice.Contains("berry"));

        //returns starting letter location of the word
        System.Console.WriteLine(fruitJuice.IndexOf("berry"));

        //returns starting letter location of the word
        System.Console.WriteLine(fruitJuice.LastIndexOf("berry"));

        //none of these are particularly useful for large amounts of strings or one with capitalizations. 

        bool containsStraw = fruitJuice.ToLower().Contains("straw");

        //should return 0
        System.Console.WriteLine(fruitJuice);
        System.Console.WriteLine(containsStraw);

        //generating strings of repeating characters. 
        //this will be repeated 40 times.
        string separator = new string('-', 40);
        System.Console.WriteLine(separator);
    }
}
