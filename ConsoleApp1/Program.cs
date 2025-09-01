using System;
using System.Collections.Generic;


namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 1,
                Name = "Test1",
                Salary = 200
            };
            Customer customer2 = new Customer()
            {
                ID = 2,
                Name = "Test2",
                Salary = 300
            };
            Customer customer3 = new Customer()
            {
                ID = 3,
                Name = "Test3",
                Salary = 400
            };


            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, customer3);


            Console.WriteLine(customers.IndexOf(customer3, 1));

            //foreach (Customer customer in customers)
            //{
            //    Console.WriteLine(customer.ID);
            //}
            


        }
    }

    public class Customer
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    //public class SavingsCustomer : Customer
    //{

    //}
}