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

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            //Console.WriteLine("Before Sorting...");
            //foreach (Customer customer in listCustomer) 
            //{
            //    Console.WriteLine(customer.Salary);
            //}

            //Console.WriteLine("After Sorting");

            //listCustomer.Sort();

            //listCustomer.Reverse();

            //foreach (Customer customer in listCustomer) 
            //{
            //    Console.WriteLine(customer.Salary);
            //}


            // Second Method passing a second class object to a sort function

            //SortByName sortByName = new SortByName();
            //listCustomer.Sort(sortByName);

            //foreach (Customer customer in listCustomer)
            //{
            //    Console.WriteLine(customer.Name);
            //}

            //Third Method

            //Comparison<Customer> customerCompairer = new Comparison<Customer> (CompareCustomer);


            //using lamda expression (x, y) => return x.ID.CompareTo(y.ID)

            listCustomer.Sort(delegate(Customer x, Customer y)
            {
                return x.ID.CompareTo(y.ID);
            });
            foreach (Customer customer in listCustomer)
            {
                Console.WriteLine(customer.ID);
            }

        }

        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }

    //Sorting with our own Classes - 2. Method IComparer
    //public class SortByName : IComparer<Customer>
    //{
    //    public int Compare(Customer x, Customer y) 
    //    {
    //        return x.Name.CompareTo(y.Name);
    //    }
    //}


    //Sorting logic within the class - 1 method....
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