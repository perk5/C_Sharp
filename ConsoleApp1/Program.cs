using System;
using System.Text;


namespace Prerak
{
    public class MainClass
    {
        public static void Main()
        {
            //string Method


            //string userString = "C#";
            //userString += " video";


            //StringBuilder Method

            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" video");


            Console.WriteLine(userString.ToString());   
        }
    }
}