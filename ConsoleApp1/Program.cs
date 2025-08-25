using System;
using System.IO;

public class ExceptionHandlingAbuse
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the Numerator: ");
            int Numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Denominator: ");
            int Denominator = int.Parse(Console.ReadLine());

            int Result = Numerator / Denominator;

            Console.WriteLine("Result {0}", Result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter an number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Only numbers between {0} && {1} are allowed",Int32.MinValue, Int32.MaxValue);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Denominator cannot be zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}