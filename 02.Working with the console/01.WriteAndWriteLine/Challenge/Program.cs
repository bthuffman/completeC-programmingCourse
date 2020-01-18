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
    }
}
