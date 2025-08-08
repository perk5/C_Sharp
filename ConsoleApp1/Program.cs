using System;
using System.Numerics;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Console.Write("Please enter your first name: ");
            //string firstname = Console.ReadLine();

            //Console.Write("Enter your last name: ");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Hello {0} {1}", firstname, lastName);

            //bool Age = true;


            //Console.WriteLine("Min Value: {0}", uint.MinValue);
            //Console.WriteLine("Max Value: {0}", uint.MaxValue);
            //double d = 23.22222222;
            //Console.WriteLine(d);

            //string name = "One\ntwo\nthree";
            //Console.WriteLine(name);
            //string path = @"c:\prerak\DotNet";
            //Console.WriteLine(path);

            //int Numerator = 10;
            //int Denominator = 2;    

            //int Result = Numerator / Denominator;
            //int password = 10;
            ////bool reEnterPassword = true;

            //bool positive =  password == 110 ? true : false;
            //Console.WriteLine(positive);

            //Console.WriteLine(" Result = {0} ", Result);
            


            //string Name = null; 
            //int? i = null;

            //bool? AreYouMajor = true;

            int? TicketOnSale = 10;

            int? AvailableTickets = TicketOnSale ?? 0;
            Console.WriteLine(AvailableTickets);
            
        }
    }
}