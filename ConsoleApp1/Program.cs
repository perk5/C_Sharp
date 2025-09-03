using System;

namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            string result = Console.ReadLine();
            Number number = new Number();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(result);
        }
    }

    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if(int.TryParse((string)target, out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}