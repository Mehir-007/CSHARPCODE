/*
Interfaces
We create interfaces using interface keyword. Just like classes interfaces also contains properties,
methods, delegates or events, but only declarations and no implementations.

It is a compile time error to provide implementations for any interface member.

Interface members are public by default, and they don't allow explicit access modifiers.

Interfaces cannot contain fields.

If a class or a struct inherits from an interface, it must provide implementation for all interface
members. Otherwise, we get a compiler error.

A class or a struct can inherit from more than one interface at the same time, but where as, a class
cannot inherit from more than once class at the same time.

Interfaces can inherit from other interfaces. A class that inherits this interface must provide
implementation for all interface members in the entire interface inheritance chain.

We cannot create an instance of an interface, but an interface reference variable can point to a
derived class object.
*/

using System;

interface IStudentID
{
    int ReturnId();
}
interface IStudentDetails : IStudentID
{
    void PrintStudentDetails();
}
interface ISection
{
    string ReturnSection(string Name);
}
class Student : IStudentDetails, ISection
{
    public int ReturnId()
    {
        return 1;
    }
    public string ReturnSection(string Name)
    {
        if (Name[0] == 'A' || Name[0] == 'M')
            return "Section A";
        else
            return "Section B";
    }
    public void PrintStudentDetails()
    {
        Console.WriteLine("Name - {0}, Id - {1}, Section - {2}", "Mehir Routh", ReturnId(), ReturnSection("Mehir Routh"));
    }

}
class Demo
{
    public static void Main()
    {
        Student student = new Student();
        student.PrintStudentDetails();
    }
}