using System;
using System.Collections.Generic;
using System.Linq;

namespace Prerak
{
    public class MainClass
    {
        public static void Main()
        {
            Country country1 = new Country() { Name = "India", Code = "IND", Capital = "Delhi" };
            Country country2 = new Country() { Name = "Australia", Code = "AUS", Capital = "Canberra" };
            Country country3 = new Country() { Name = "Afghanistan", Code = "AFG", Capital = "Kabul" };
            Country country4 = new Country() { Name = "Iran", Code = "IRN", Capital = "Tehran" };
            Country country5 = new Country() { Name = "Pakistan", Code = "PAK", Capital = "Islamabad" };

            Queue<Country> queueCustomers = new Queue<Country>();
            queueCustomers.Enqueue(country1);
            queueCustomers.Enqueue(country2);
            queueCustomers.Enqueue(country3);
            queueCustomers.Enqueue(country4);
            queueCustomers.Enqueue(country5);


            //FIFO (First In First Out)
            //Remove and just Return
            //Country c1 = queueCustomers.Dequeue();
            //Console.WriteLine(c1.Name);

            //Doesnot Remove and just Return
            Country c1 = queueCustomers.Peek();
            Console.WriteLine(c1.Name);


            foreach (Country c in queueCustomers)
            {  
                Console.WriteLine(queueCustomers.Count());
            }

        }
    }
     
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }   
        public string Capital { get; set; }
    }
}