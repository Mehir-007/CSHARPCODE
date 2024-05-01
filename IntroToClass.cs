/*
A class is a user-defined data type that defines a blueprint for objects. 
It encapsulates data for the object and methods to operate on that data.

In C#, the this keyword refers to the current instance of the class and is used to access members of the current object.
Benifits of using "this" keyword-
1.Clarity and Readability
2.It resolves the ambiguity between class members and parameters with the same name.
3.this keyword is used to call another constructor in the same class. This is particularly useful for constructor overloading or constructor chaining.
4.The this keyword can also be used to allow method chaining.
5.You can pass the current object as a parameter to another method.
6.You can use the this keyword to define extension methods. An extension method is a static method of a static class, where the 'this' modifier is applied to the first parameter.
*/
using System;

class Employee
{
    string FirstName;
    string LastName;
    public Employee(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public void print()
    {
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
    }
}
class CSharp
{
    public static void Main()
    {
        Employee E1 = new Employee("Mehir", "Routh");
        E1.print();
    }
}