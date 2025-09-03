using System;

namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Please enter the target number");
            int target = int.Parse(Console.ReadLine());
            Number number = new Number(target);

            ////Optional
            //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            //

            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    class Number
    {
        int _target;

        public Number(int target)
        {
            this._target = target;
        }
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}