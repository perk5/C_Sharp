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

            // Converting Arrays to dictionary....

            Customer[] customer = new Customer[3];
            customer[0] = customer1;
            customer[1] = customer2;
            customer[2] = customer3;

            Dictionary<int, Customer> dict = customer.ToDictionary(cust => cust.ID, cust => cust);


            foreach (KeyValuePair <int, Customer> kvp in dict)
            {
                Console.WriteLine(kvp.Key);
            }

            

            // Create Dictionary

            //Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            //dictionaryCustomers.Add(customer1.ID, customer1);
            //dictionaryCustomers.Add(customer2.ID, customer2);






            //Method TryGetValue Method.....

            //Customer cust;
            //if (dictionaryCustomers.TryGetValue(4, out cust))
            //{
            //    Console.WriteLine(cust.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found...");
            //}


            // Count Extension Method......
            //int count = dictionaryCustomers.Count(kvp => kvp.Value.Salary >= 300);
            //Console.WriteLine(count);

            //// Remove Method......
            //dictionaryCustomers.Remove(35);

        }
    }

    public class Customer
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
}