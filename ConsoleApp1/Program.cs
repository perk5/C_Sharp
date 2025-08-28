using System;

namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();

            C1.FirstName = "Prerak";
            C1.LastName = "Shah";

            Console.WriteLine(C1.ToString());
        }
    }

    public class Customer
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;  
        }
        
    }
}