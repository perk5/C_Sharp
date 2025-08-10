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

            //int TotalCoffeeCost = 0;
            //string userDecision = "";

            //    do
            //    {
            //        int userChoice = 0;
            //        do
            //        {
            //            Console.WriteLine("1. Small, 2. Medium, 3. Large: ");
            //            userChoice = int.Parse(Console.ReadLine());

            //            if(userChoice != 1 && userChoice != 2 && userChoice != 3)
            //            {
            //                Console.WriteLine("Please Choose between 1 2 3 ");
            //            } else
            //            {
            //                TotalCoffeeCost += userChoice;
            //            }
            //        } while (userChoice != 1 && userChoice != 2 && userChoice != 3);

            //        do
            //        {
            //            Console.Write("Do you want to buy another coffee? Yes or No: ");

            //            userDecision = Console.ReadLine().ToLower();

            //            if (userDecision != "yes" && userDecision != "no")
            //            {
            //                Console.WriteLine("Your Choice is invalid...Please try Again..");
            //            }
            //        } while (userDecision != "yes" && userDecision != "no");

            //    } while (userDecision != "no");



            //    Console.WriteLine("Your TotalCoffeeCost: {0}", TotalCoffeeCost);

            //int Start = 0;

            //while(Start <= userTarget)
            //{
            //    Console.Write(Start + " ");
            //    Start += 2;
            //}
            //string UserChoice = "";
            //do
            //{
            //    Console.Write("Please enter your target?  ");
            //    int UserTarget = int.Parse(Console.ReadLine());

            //    int Start = 0;

            //    while (Start <= UserTarget)
            //    {
            //        Console.Write(Start + " ");
            //        Start += 2;
            //    }


            //    do
            //    {
            //        Console.Write("Do you want to Continue? ");
            //        UserChoice = Console.ReadLine().ToLower();

            //        if (UserChoice != "yes" && UserChoice != "no")
            //        {
            //            Console.WriteLine("Please Choose between \"Yes\" or \"No\"");
            //        }
            //    } while (UserChoice != "yes" && UserChoice != "no");
            //} while (UserChoice != "no");

            //int[] numbers = new int[3];

            //numbers[0] = 101;
            //numbers[1] = 102;
            //numbers[2] = 103;

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    Console.WriteLine(numbers[j]);

            //}


            //while(count < numbers.Length)
            //{
            //    Console.Write(numbers[count] + " ");
            //    count++;
            //}

            Program.EvenNumbers(30);
            Program p = new Program();
            int sum = p.Add(20, 30);
            Console.WriteLine(sum);    


        }

        public int Add(int Fn, int Sn)
        {
            return Fn + Sn;
        }

        public static void EvenNumbers(int target)
        {
            int start = 0;

            while(start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        
    }
}