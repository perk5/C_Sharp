using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
           
            Program.AddNumbers(1, 2);
        }

        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;    
                }
            }

            Console.WriteLine(result);  
        }
    }
}