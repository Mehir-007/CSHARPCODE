/*
if someone wants to change the criteria of Promote Employee logic he has to change the employee class
we can fix that using deligates using callback funtion.
Delegates provides flexibility so that any developer using our employee class can plugin there logic 
without them having to modify our class.
We use delegate to pass function as parameter.
*/
using System;
using System.Collections.Generic;

class Demo
{
    public static void Main()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new Employee() { Id = 101, Name = "Shiv", Salary = 100000, Experience = 5 });
        list.Add(new Employee() { Id = 101, Name = "David", Salary = 100000, Experience = 4 });
        list.Add(new Employee() { Id = 101, Name = "Ram", Salary = 100000, Experience = 5 });
        list.Add(new Employee() { Id = 101, Name = "Shiv", Salary = 100000, Experience = 3 });
        IsPromotable isPromotable = new IsPromotable(Promote); //Instance if an delegate
        Employee.PromoteEmployee(list, isPromotable); //Passing a delegate which is actually a funtion pointer hence passing a function
    }
    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
            return true;
        return false;
    }
}

delegate bool IsPromotable(Employee emp); //Delegate
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee emp in employeeList)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine("{0} is promoted", emp.Name);
            }
        }
    }
}