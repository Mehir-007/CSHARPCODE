/*
Polymorphism
Polymorphism enables to evoke derived class methods from base class referance variables at runtime

*/
using System;

class Employee
{
    public string FirstName = "FN";
    public String LastName = "LN";
    public virtual void Print()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
class FullTimeEmployee : Employee
{
    public override void Print()
    {
        Console.WriteLine(FirstName + " " + LastName + " is a FullTimeEmployee");
    }
}
class PartTimeEmployee : Employee
{
    public override void Print()
    {
        Console.WriteLine(FirstName + " " + LastName + " is a PartTimeEmployee");
    }
}
class Intern : Employee
{
    public override void Print()
    {
        Console.WriteLine(FirstName + " " + LastName + " is a Intern");
    }
}
class Demo
{
    public static void Main()
    {
        Employee[] emp = new Employee[3];
        emp[0] = new FullTimeEmployee();
        emp[1] = new PartTimeEmployee();
        emp[2] = new Intern();
        foreach (Employee e in emp)
        {
            e.Print();
        }
    }
}