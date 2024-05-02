/*
 We use get and set accessors to implement properties
A property with both get and set accessors is a Read/Write property
A property with only get accessor is a Read only property
A property with ony set accessor is a Write only property

The advantage of properties over Get() and Set() methods is that , you can access
them as if they were public fields

If there is no additional logic in the property accessors then we can make use of 
auto-implemented properties introduced in C# 3.0
Auto-implemented properties reduce the amount of code that we have to write.
When you use auto-implemented properties, the compiler creates a private, anonymous
field that can only be accessed through the property's get and set accessors 

 */
using System;

class Student
{
    private int _id;
    private string _name;
    private string _email;
    private int _passMarks;

    public int ID                               //read/write property
    {
        set
        {
            if (value < 0)
            {
                throw new Exception("Id Can'not be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    public string Name
    {
        set
        {
            if (value == null)
            {
                throw new Exception("Name Can'not be null");
            }
            this._name = value;
        }
        get
        {
            if (this._name == null)
            {
                return "No Name";
            }
            return this._name;
        }
    }
    public string Email { set; get; } //Auto-Implemented property
    public int PassMarks { get; } //readonly
}
class Demo
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.ID = 1; S1.Name = "Mehir Routh"; S1.Email = "abcd@gmail.com";

        Console.WriteLine("Name = {0}, ID = {1} , Email = {2}", S1.Name, S1.ID, S1.Email);
    }
}