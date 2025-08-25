using System;
using System.Data;
using System.IO;

public class ExceptionHandlingAbuse
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the Numerator: ");
            int Numerator;
            bool isNumeratorConvertedSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

            if (isNumeratorConvertedSuccessful)
            {
                Console.WriteLine("Please enter Denominator: ");

                int Denominator;

                bool isDenominatorConvertedSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (isDenominatorConvertedSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;

                    Console.WriteLine("Result {0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should a valid number {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
                    }      
                }


            }
            else
            {
                Console.WriteLine("Numerator should a valid number {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);   
        }
    }
}