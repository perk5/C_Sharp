using System;


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

            //int? TicketOnSale = 10;

            //int? AvailableTickets = TicketOnSale ?? 0;
            //Console.WriteLine(AvailableTickets);


            //float f = 23.434F;

            //int i = Convert.ToInt32(f);

            //Console.WriteLine(i);

            //string number = "100";

            //int result = 0;

            //bool isConversionSuccessful = int.TryParse(number, out result);

            //if (isConversionSuccessful)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Cannot Convert the string into an array");
            //}

            //Console.WriteLine(result);  

            //int[] EvenNumbers = new int[4];

            //EvenNumbers[0] = 0;
            //EvenNumbers[1] = 2;
            //EvenNumbers[2] = 4;
            //EvenNumbers[3] = 6;

            //Console.WriteLine(EvenNumbers);

            //Console.Write("Please enter a number: ");
            //int userNumber = int.Parse(Console.ReadLine());

            //if (userNumber == 0)
            //{
            //    Console.WriteLine("Hello number is 0");
            //}
            //else
            //{
            //    Console.WriteLine("Hello number is not 0");
            //}

            
                Console.Write("Please Enter a Number: ");
                int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                    Console.WriteLine("Your Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                default:
                    Console.WriteLine("Number is not in range");
                    break;
            }

            

        }
    }
}