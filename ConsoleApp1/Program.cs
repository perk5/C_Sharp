using System;

namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {
            //int i = 10;
            //int j = 10;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            Customer C1 = new Customer();
            C1.FirstName = "Prerak";
            C1.LastName = "Shah";

            Customer C2 = new Customer();
            C2.FirstName = "Prerak";
            C2.LastName = "Shah";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C2.Equals(C1));



        }
    }

    public class Customer
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }


        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if (!(obj is Customer)) 
            { 
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();  
        }
    }
}