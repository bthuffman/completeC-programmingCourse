class EntryPoint
{
    static void Main()
    {
        int bigNumber = 4564532;

        System.Console.WriteLine(bigNumber.ToString().Contains("5"));
        System.Console.WriteLine(bigNumber.ToString().IndexOf("5"));
        System.Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));

        string iLearn = "I am learning ";
        string nameOfCourse = "C# Mastercourse";

        string concantenated = iLearn + nameOfCourse + 5 + true + 'd';

        System.Console.WriteLine(concantenated);


    }
}