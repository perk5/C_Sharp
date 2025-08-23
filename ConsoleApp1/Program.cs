using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

class ExceptionHandling
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {

            streamReader = new StreamReader(@"D:\Sample file\Data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            
            Console.WriteLine("Finally Called");
        }

    }
}