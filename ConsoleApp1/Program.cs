using System;
using System.Runtime.Intrinsics.Arm;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


namespace ConsoleApp1
{

    //class Customer
    //{
    //    string _firstName;
    //    string _lastName;

       

    //    public Customer(string FirstName, string LastName)
    //    {
    //        this._firstName = FirstName;
    //        this._lastName = LastName;  
    //    }

    //    public Customer() : this("No firstName", "lastName provided")
    //    {

    //    }

    //    public void PrintFullName()
    //    {
    //        Console.WriteLine(this._firstName + " " + this._lastName);
    //    }

    //    ~Customer() 
    //    {
    //        //Clean Up Code
    //    }

    //}

    //class Circle
    //{
    //    static float _PI;
    //    int _Radius;

    //    static Circle()
    //    {
    //        Circle._PI = 3.141F;
    //    }

    //    public Circle(int Radius)
    //    {
    //        this._Radius = Radius;
    //    }

    //    public float CalculateArea()
    //    {
    //        return Circle._PI * (this._Radius * this._Radius);
    //    }
    //}

    //public class Employee
    //{
    //    public string FirstName = "Fn";
    //    public string LastName = "Ln";
    //    public virtual void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName);
    //    }
    //}

    //public class FullTimeEmployee : Employee
    //{
    //    public override void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    //    }
    //}

    //public class PartTimeEmployee : Employee
    //{
    //    public override void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    //    }

    //}

    //public class TemporaryEmployee : Employee
    //{
    //    public override void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName + " - Temporary");
    //    }
    //}
   
    public struct Student
    {
        private int _id;
        private string _name;
        private int PassMark = 35;

        public int ID {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name { get => _name; set => _name = value; }


        public Student(int id, string Name)
        {
            this._id = id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("ID = {0} && Name = {1}", this._id, this._name);
        }


        //public int GetPassMark()
        //{
        //    return this.PassMark;
        //}

        //public void SetName(string Name)
        //{
        //    if (string.IsNullOrEmpty(Name))
        //    {
        //        throw new Exception("Name is empty or Null");
        //    }
        //    this.Name = Name;
        //}

        //public string GetName()
        //{

        //    return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;

        //}

        //public int Id
        //{
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Id must me more than 0 and should not be negative");
        //        }
        //        this._id = value;
        //    }
        //    get
        //    { 
        //        return this._id;
        //    }  
        //}

        //public int GetId()
        //{
        //    return this.Id;
        //}
    }

    public class Program
    {

        static void Main()
        {



            Student S1 = new Student(101, "Prerak");
            S1.PrintDetails();
            Student S2 = new Student();
            S2.ID = 20;
            S2.Name = "Prerak";
            S2.PrintDetails();
            Student S3 = new Student()
            {
                ID = 103,
                Name = "ROb"
            };
            S3.PrintDetails();



            //Employee[] employees = new Employee[4];

            //employees[0] = new Employee();
            //employees[1] = new FullTimeEmployee();
            //employees[2] = new PartTimeEmployee();
            //employees[3] = new TemporaryEmployee();

            //foreach (Employee e in employees) 
            //{
            //    e.PrintFullName();
            //}

            //FullTimeEmployee F1 = new FullTimeEmployee();
            //F1.FirstName = "Prerak";
            //F1.LastName = "Shah";
            //F1.PrintFullName();

            //PartTimeEmployee P1 = new PartTimeEmployee();
            //P1.FirstName = "PartTime";
            //P1.LastName = "Employee";
            //P1.PrintFullName();
            //Circle C1 = new Circle(5);
            //float Area1 = C1.CalculateArea();
            //Console.WriteLine("Area: {0}", Area1);


            //Circle C2 = new Circle(6);
            //float Area2 = C2.CalculateArea();
            //Console.WriteLine("Area: {0}", Area2);

            //Customer C1 = new Customer("Prerak", "Shah");
            //C1.PrintFullName();



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

            //Program.EvenNumbers(30);
            //Program p = new Program();
            //int sum = p.Add(20, 30);
            //Console.WriteLine(sum);

            //int total = 0;
            //int Product = 0;
            //Program.Addition(10, 20, out total, out Product);

            //Console.WriteLine(total);
            //Console.WriteLine(Product);


            //int[] numbers = new int[3];

            //numbers[0] = 1;     
            //numbers[1] = 2;
            //numbers[2] = 3;

            //ParamsMethod(numbers);

            //PATA.ClassA.Print();
            //PATB.ClassA.Print();
        }
    }
}




//public static void ParamsMethod(params int[] numbers)
//{
//    Console.WriteLine(" There are {0} elements ", numbers.Length);

//    foreach (int number in numbers)
//    {
//        Console.WriteLine(number);
//    }
//}

//public static void Addition(int Fn, int Sn, out int sum, out int Product)
//{
//    sum =  Fn + Sn;
//    Product = Fn * Sn;
//}

//public int Add(int Fn, int Sn)
//{
//    return Fn + Sn;
//}

//public static void EvenNumbers(int target)
//{
//    int start = 0;

//    while(start <= target)
//    {
//        Console.WriteLine(start);
//        start += 2;
//    }
//}