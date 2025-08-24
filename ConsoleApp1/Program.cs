using System;
using System.IO;


class InnerException
{
    public static void Main()
    {

        Divide(); 
    }

    public static void Divide()
    {
        try
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Result: {0}", firstNumber / secondNumber);
            }
            catch (Exception ex)
            {
                string filePath = @"D:\Sample file\Data111.txt";

                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.Close();
                    Console.WriteLine("There is a problem, Please try later");

                }
                else
                {
                    throw new FileNotFoundException(filePath, " Not Present");
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("Current Exception = {0}", exception.GetType().Name);

            if(exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
            
        }
        
        
    }
}
    