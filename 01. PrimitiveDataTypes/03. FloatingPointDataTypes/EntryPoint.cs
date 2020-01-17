class EntryPoint
{
    static void Main()
    {
        float someFloatNumber = 64564565465454.43f;

        System.Console.WriteLine(someFloatNumber.ToString("f"));

        float radius = 5f;
        float pi = 3.14f;

        float areaOfACircle = pi * radius * radius;

        System.Console.WriteLine(areaOfACircle);

        float fMax = float.MaxValue;
        float fMin = float.MinValue;

        System.Console.WriteLine(fMax.ToString("f"));
        System.Console.WriteLine(fMin.ToString("f"));

        double dVariable = 3.14d;

        double doubleMax = double.MaxValue;
        double doubleMin = double.MinValue;

        System.Console.WriteLine(doubleMax.ToString("f"));
        System.Console.WriteLine(doubleMin.ToString("f"));

        decimal decimalMax = 5435.3453453453453453453453454353453534534534534m;
        decimal decimalMin = decimal.MinValue;

        System.Console.WriteLine(decimalMax);
        System.Console.WriteLine(decimalMin);
    }
}
