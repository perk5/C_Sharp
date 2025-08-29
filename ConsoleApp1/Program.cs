using System;

namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = null;
            string str = Convert.ToString(C1);
            //string str = C1.ToString(); -> Throws a nullReferenceError
            Console.WriteLine(str); 
        }
    }

    public class Customer
    {
        public string Name { get; set; }

          
    }

    
}