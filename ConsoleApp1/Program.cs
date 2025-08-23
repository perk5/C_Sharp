using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Mark", Salary = 20000, Experience = 5 });
        empList.Add(new Employee() { Id = 102, Name = "Mary", Salary = 60000, Experience = 4 });
        empList.Add(new Employee() { Id = 103, Name = "John", Salary = 10000, Experience = 1 });
        empList.Add(new Employee() { Id = 104, Name = "Tony", Salary = 30000, Experience = 8 });

        IsPromotable Ispromotable = new IsPromotable(Promote);

        Employee.PromoteEmployee(empList, Ispromotable);
    }
    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }
    
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if(IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }
}