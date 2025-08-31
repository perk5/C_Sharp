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

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);

            Customer cust2 = dictionaryCustomers[2];

            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust2.ID, cust2.Name, cust2.Salary);

            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers )
            {
                //Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
                Customer Cust = customerKeyValuePair.Value;
                Console.WriteLine(Cust.Name);
            }
        } 
    }

    public class Customer
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
}