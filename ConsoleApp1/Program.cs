using System;

public class Enums
{
    public static void Main()
    { 
        Gender gender = (Gender)Season.Monsoon;
        int Number = (int)Gender.Unknown;
        Console.WriteLine(gender);
        Console.WriteLine(Number);

        //short[] values = (short[])Enum.GetValues(typeof(Gender));

        //foreach(short i in values)
        //{
        //    Console.WriteLine(i);
        //}

        //string[] Names = Enum.GetNames(typeof(Gender));

        //foreach(string s in Names)
        //{
        //    Console.WriteLine(s);
        //}
    }
    
}

public enum Gender
{
    Unknown = 1,
    Male = 2,
    Female = 3
}

public enum Season
{
    Winter = 0,
    Summer,
    Monsoon
}

