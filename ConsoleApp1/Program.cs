using System;

namespace ThreadStartDelegateExample
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine(sum); 
        }
        public static void Main()
        {
            Console.WriteLine("Please Enter the number: ");
            int result = int.Parse(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSumOfNumbers);

            Number number = new Number(result, callback);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            T1.Start();
           
        }
    }

    class Number
    {
        int _target;
        SumOfNumbersCallback _sumOfNumbersCallback;
        public Number(int target, SumOfNumbersCallback sumOfNumbersCallback)
        {
            this._target = target;
            this._sumOfNumbersCallback = sumOfNumbersCallback;
        }

        public void PrintNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if(_sumOfNumbersCallback != null)
            {
                _sumOfNumbersCallback(sum);
            }
        }
    }
}