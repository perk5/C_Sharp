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
                Salary = 200,
                Type = "CorporateCustomer"
            };
            Customer customer2 = new Customer()
            {
                ID = 2,
                Name = "Test2",
                Salary = 300,
                Type = "CorporateCustomer"
            };
            Customer customer3 = new Customer()
            {
                ID = 3,
                Name = "Test3",
                Salary = 800,
                Type = "RetailCustomer"
            };

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer3);

            listCustomer.AddRange(listCorporateCustomers);

            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.Name);
            }


            //List<Customer> customers = new List<Customer>(2);
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);

            //FindAll Function......
            //List<Customer> cust = customers.FindAll(cust => cust.Salary > 200);

            //foreach (Customer c in cust)
            //{
            //    Console.WriteLine(c.Name);
            //}


            ////FindIndex / FindLastIndex  Function......
            //int cust = customers.FindLastIndex(cust => cust.Salary == 300);

            //Console.WriteLine(cust);    


            //Contains Function......

            //if (customers.Contains(customer3))
            //{
            //    Console.WriteLine("Customer exists");
            //}
            //else
            //{
            //    Console.WriteLine("Customer Do not exist");
            //}

            //Exists function.......

            //if (customers.Exists(cust => cust.Name.StartsWith("T")))
            //{
            //    Console.WriteLine("Customer exists");
            //}
            //else
            //{
            //    Console.WriteLine("Customer Do not exist");
            //}




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

        public string Type { get; set; }
    }

    //public class SavingsCustomer : Customer
    //{

    //}
}