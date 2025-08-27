using System;
using System.Reflection;


namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {   
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Prerak.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];

            parameters[0] = "Prerak";
            parameters[1] = "Shah";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine(fullName);

            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Prerak", "Shah");
            //Console.WriteLine(fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}