
    class Program
    {
        static void Main()
        {
        int bigNumber = 45651283;

        //in order to see if it contains 5 we need to turn it into a string (contains method not for ints). 
        System.Console.WriteLine(bigNumber.ToString().Contains("5"));
        //Same for IndexOf and LastindexOf

        //If you combine variables of different types to a Console.WriteLine they will display (bool + int + string etc)


        //THREE DIFF WAYS OF DOING STRINGS
        string nameOfShip = "Enterprise";

        int damageTaken = 100;

        string spellName = "Fireball";

        //long way of doing 
        string damageReport = "The " + nameOfShip + " took " + damageTaken + " damage from " + spellName;

        System.Console.WriteLine(damageReport);

        //shorter way of doing
        string damageReportV2 = string.Format("The starship {0} took {1} damage from {2}", nameOfShip, damageTaken, spellName);

        System.Console.WriteLine(damageReportV2);

        //interpolation, THE BEST
        string damageReportV3 = $"The starship {nameOfShip} took {damageTaken} damage from {spellName}";

        System.Console.WriteLine(damageReportV3);
    }
    }
