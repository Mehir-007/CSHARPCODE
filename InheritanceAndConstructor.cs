/*
 To call parent class constructor of our choice we use :base() in clild class constructor
 */
using System;
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Hello this is ParentClass default constructor");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}
public class ChildClass : ParentClass
{
    public ChildClass(string Message) : base(Message)
    {
        Console.WriteLine("Hello this is ChildClass default constructor");
    }
}
class Demo
{
    public static void Main()
    {
        ChildClass CC = new ChildClass("This is how you call parameterized constructor of parent class using constructor overloading");
    }
}