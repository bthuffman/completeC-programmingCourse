class EntryPoint
{
    static void Main(string[] args)
    {
        //float can hold values with precision of 7 values including negatives. Numbers beyond this support will not be included, and will be rounded up (7 digit precision)
        //use f
        float pie = 3.14666666666f;

        System.Console.WriteLine(pie);
https://www.udemy.com/course/the-complete-csharp-programming-course/
        float anotherNumber = 234134523463.0123f;

        System.Console.WriteLine(anotherNumber);

        //to write it so that it includes 0 for the numbers after 7
        System.Console.WriteLine(anotherNumber.ToString("f"));

        //challenge calc area of circle. Pie*r^2
        int radius = 5;
        float pieNumber = 3.141592653589793238f;
        var areaOfCircle = radius * radius * pieNumber;

        System.Console.WriteLine(areaOfCircle);

        //float has almost 32 bits that it can hold, but it doesn't hold as wide a range of values. See this to the ToString("f") to see this demonstrated.
        float fMax = float.MaxValue;

        System.Console.WriteLine(fMax.ToString("f"));

        //to achieve more precision we can use double which still includes negatives between 179 quadrillions. 15 - 16 precision
        double doubleMax = double.MaxValue;
        //use d
        double secondDouble = 6545.2455d;

        System.Console.WriteLine(doubleMax);

        //even greater precision from decimal (28 digits)
        decimal decimalMax = decimal.MaxValue;
        decimal decimalNumber = 215781.121564216545m;

        System.Console.WriteLine(decimalMax);
    }
}
