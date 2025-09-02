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

            Dictionary<string, Country> Countries = new Dictionary<string, Country>();
            Countries.Add(country1.Code, country1);
            Countries.Add(country2.Code, country2);
            Countries.Add(country3.Code, country3);
            Countries.Add(country4.Code, country4);
            Countries.Add(country5.Code, country5);
                 
            string answer;
            do
            {
                Console.WriteLine("Please enter country code: ");
                string Code = Console.ReadLine().ToUpper();


                Country c = Countries.ContainsKey(Code) ? Countries[Code] :  null;

                if (c != null)
                {
                    Console.WriteLine(c.Name);
                }
                else
                {
                    Console.WriteLine("We were not able to find the name of the country..");
                }
                Console.WriteLine("");

                do
                {
                    Console.Write("Do you want to continue Yes or No: ");
                    answer = Console.ReadLine().ToLower();
                } while (answer != "no" && answer != "yes");



                //foreach (Country C in countries)
                //{
                //    if (C.Code == Code)
                //    {
                //        Console.WriteLine("Country: " + C.Name);

                //        answer = Console.ReadLine();
                //    }
                //    else
                //    {

                //    }
                //    Console.WriteLine("Do You want to continue Yes or No: ");
                //}



                } while (answer != "no");

    
        }
    }
     
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }   
        public string Capital { get; set; }
    }
}