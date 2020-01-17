class EntryPoint
{
    static void Main()
    {
        string nameOfCharacter = "Tod";
        string spellName = "Fireball";
        int damageTaken = 100;

        string damageReport = "The " + nameOfCharacter + " character took " + damageTaken + " damage from " + spellName;
        string damageReportV2 = string.Format("The {0} character took {1} damage from {2}", nameOfCharacter, spellName, damageTaken );
        string damageReportV21 = string.Format("The {1} character took {0} damage from {2}, and the character {1} is now dead", damageTaken, nameOfCharacter, spellName );

        System.Console.WriteLine(damageReport);
        System.Console.WriteLine(damageReportV2);
        System.Console.WriteLine(damageReportV21);

        string damageReportV3 = $"The {nameOfCharacter} character took {damageTaken} damage from {spellName}";
        System.Console.WriteLine(damageReportV3);
    }
}