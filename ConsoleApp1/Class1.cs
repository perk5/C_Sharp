using System;
using System.Collections.Generic;

namespace ConsoleApp1
{ 
    public class Employee
    {
        public int employeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Company
    {
        private List<Employee> employeeList;

        public Company()
        {
            employeeList = new List<Employee>();
            employeeList.Add(new Employee() { employeeId = 1, Name = "Prerak", Age = 25 });
            employeeList.Add(new Employee() { employeeId = 2, Name = "Raj", Age = 24 });
            employeeList.Add(new Employee() { employeeId = 3, Name = "Ram", Age = 11 });
            employeeList.Add(new Employee() { employeeId = 4, Name = "Avtar", Age = 51 });
        }


        public string this[int employeeId]
        {
            get
            {
                foreach (Employee e in employeeList)
                {
                    if (e.employeeId == employeeId)
                    {
                        return e.Name;
                    }  
                }

                return "Not Found";
            }

            set
            {
                foreach (Employee e in employeeList)
                {
                    if (e.employeeId == employeeId)
                    {
                        e.Name = value;
                    }
                }
            }
        }
    }

}
