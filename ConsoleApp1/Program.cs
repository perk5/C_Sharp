using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 5,
                Name = "Cest1",
                Salary = 200,
                Type = "CorporateCustomer"
            };
            Customer customer2 = new Customer()
            {
                ID = 2,
                Name = "Dast2",
                Salary = 1900,
                Type = "CorporateCustomer"
            };
            Customer customer3 = new Customer()
            {
                ID = 3,
                Name = "Aorth3",
                Salary = 800,
                Type = "RetailCustomer"
            };

            List<Customer> listCustomer = new List<Customer>(100);
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            //Capacity Triming method
            Console.WriteLine(listCustomer.Capacity);
            listCustomer.TrimExcess();
            Console.WriteLine(listCustomer.Capacity);


            //AsReadOnly();

            //ReadOnlyCollection<Customer> readOnly= listCustomer.AsReadOnly();
            

            //TrueForAll Method

            //bool result = listCustomer.TrueForAll(x => x.Salary > 200);
            //Console.WriteLine(result);

            // 
        }

        
    }
   
    public class Customer : IComparable<Customer>
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; } 
        public int CompareTo(Customer other)
        {
            //if(this.Salary > other.Salary)
            //{
            //    return 1;
            //}
            //else if ((this.Salary < other.Salary))
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.Salary.CompareTo(other.Salary);
        }
    }

    //public class SavingsCustomer : Customer
    //{

    //}
}