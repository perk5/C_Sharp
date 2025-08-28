using System;

namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<string>("", "");

            if (Equal)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}