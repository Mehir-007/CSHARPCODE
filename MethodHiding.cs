/*
Using the new keyword to hide a base class member.You will get a compiler warning,
if we miss the new keyword.
Different Ways to invoke a hidden base class member from derived class
1.Use base keyword
2.Cast child type to parent type and invoke the hidden member
3.ParentClass PC = new ChildClass()
PC.HiddenMenthod()
*/

using System;
class ParentClass
{
    public string Name;
    public int Age;
    public void Print()
    {
        Console.WriteLine("Name {0} , Age {1} from parent", this.Name, this.Age);
    }
}
class ChildClass : ParentClass
{
    public new void Print()
    {
        Console.WriteLine("Name {0} , Age {1} from child", this.Name, this.Age);
    }
}
class Demo
{
    public static void Main()
    {
        ChildClass CS = new ChildClass();
        CS.Name = "Mehir";
        CS.Age = 23;
        CS.Print();
    }
}