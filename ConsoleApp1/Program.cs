using System;

namespace ConsoleApp1
{
    public class MainClass
    {
        public static void Main()
        {
            Company C1 = new Company();
            Console.WriteLine("First Employee Name = " + C1[1]);
            Console.WriteLine("First Employee Name = " + C1[2]);
            Console.WriteLine("First Employee Name = " + C1[3]);

            C1[1] = "Changed Prerak";
            C1[2] = "Changed Raj";
            C1[3] = "Changed Ram";

            Console.WriteLine("First Employee Name = " + C1[1]);
            Console.WriteLine("First Employee Name = " + C1[2]);
            Console.WriteLine("First Employee Name = " + C1[3]);
        }
    }
}