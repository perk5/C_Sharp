using System;
using System.Runtime.InteropServices;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Program.AddNumbers(1 , 2);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
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