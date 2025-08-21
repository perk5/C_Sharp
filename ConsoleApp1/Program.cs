using System;
//interface ICustomer1
//{
//    void Print();   
//}

//interface ICustomer2
//{
//    void I2Method();
//}

//public class Customer : ICustomer2
//{
//    public void Print()
//    {
//        Console.WriteLine("How Are you");
//    }
//    public void I2Method()
//    {
//        Console.WriteLine("I2");
//    }
//}

//interface I1
//{
//    void InterfaceMethod();
//}
//interface I2
//{
//    void InterfaceMethod();
//}

public abstract class Customer
{
    public abstract void Print();
}

public abstract class Program : Customer
{
    //void I1.InterfaceMethod()
    //{
    //    Console.WriteLine("I1");
    //}

    //void I2.InterfaceMethod()
    //{
    //    Console.WriteLine("I2");
   
    static void Main()
    {
        //Program P1 = new Program();
        //((I1)P1).InterfaceMethod();

       //Customer C = new Program();
       //C.Print();
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