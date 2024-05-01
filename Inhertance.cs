/*
Inheritance in C# allows one class (called the derived class or subclass) to 
inherit members (fields, properties, methods) from another class (called the base class or superclass). 
This concept enables code reusability and promotes a hierarchical structure in your code.
C# only supports single class inheritance but supports multiple interface inheritance
C# supports multilevel inheritance
*/
using System;
/// <summary>
/// Base Class Employee.
///Stores Common Data like name,email for all kinds of different Employee
/// </summary>
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine("Hello {0} {1}", this.FirstName, this.LastName);
    }
}
/// <summary>
/// Derived class FTE that inherits from class Employee
/// </summary>
public class FullTimeEmployee : Employee
{
    float YearlySalary;
}
/// <summary>
/// Derived class PTE that inherits from class Employee
/// </summary>
public class PartTimeEmployee : Employee
{
    float HourlySalary;
}
class Demo
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Mehir";
        FTE.LastName = "Routh";
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Shahid";
        PTE.LastName = "Kapoor";
        PTE.PrintFullName();


    }
}