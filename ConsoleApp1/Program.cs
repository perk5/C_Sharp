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

            Stack<Country> queueCustomers = new Stack<Country>();
            queueCustomers.Push(country1);
            queueCustomers.Push(country2);
            queueCustomers.Push(country3);
            queueCustomers.Push(country4);
            queueCustomers.Push(country5);

            queueCustomers.Pop();

            foreach (Country c in queueCustomers)
            {
                Console.WriteLine(c.Name);
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