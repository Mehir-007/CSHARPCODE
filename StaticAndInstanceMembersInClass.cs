/*
When a class member includes a static modifier , the member is called a static member.
When no static modifier is present the member is called a no static member or Instance member.

Static member are invoked using class name, where as intance member are invoked 
using intances(object) of the class.

An instance member belongs to specific intance(object) of a class. If I create 3
objects of a class, I will have # sets of intance members in the memory , whereas 
there will be only one copy of a static member, no matter how amny instances of a class is 
created.

Static Constructor:
Static constructors are used to initialize static feilds in a class.
Static constructor is called only once, no matter how many intances you create.
Static constructors are called before instance constructors.
*/
using System;

class Circle
{
    static float PI;
    float Radius;
    static Circle()
    {
        Console.WriteLine("Static Constructor Called");
        PI = 3.14F;
    }
    public Circle(float radius)
    {
        Console.WriteLine("Instance Constructor Called");
        this.Radius = radius;
    }
    public float area() { return Radius * Radius * PI; }
}
class Demo
{
    public static void Main()
    {
        Circle C1 = new Circle(5F);
        float Area1 = C1.area();
        Console.WriteLine(Area1);
        Circle C2 = new Circle(6F);
        float Area2 = C2.area();
        Console.WriteLine(Area2);
    }
}