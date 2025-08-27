using System;
using System.Reflection;

namespace Prerak
{
    public class MainClass
    {
        private static void Main()
        {
            Type T = Type.GetType("Prerak.Customer");
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);
            Console.WriteLine("");
            Console.WriteLine("Properties");

            PropertyInfo[] p1 = T.GetProperties();

            foreach (PropertyInfo p in p1)
            {
                Console.WriteLine(p.PropertyType.Name + " " + p.Name);
            }
        }
    }


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("ID = {0}", this.Name);
        }
    }
}