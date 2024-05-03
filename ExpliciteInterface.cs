/*
Explicit interface implementation
Question: A class inherits from 2 interfaces and both the interfaces have the
same method name. How should the class implement the method for both the
interfaces?

We are using Explicit Interface Implementation technique to solve this problem.

Note: When a class explicitly implements, an interface member, the interface member
can no longer be accessed through class reference variable, but only through the interface reference
variable.

Access modifiers are not allowed on explicite implemented interface members.
*/

using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
class Demo : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface is implemented");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface is implemented");
    }
    public static void Main()
    {
        Demo P = new Demo();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
    }
}

/*
 If we want to make onr of the interface method , the default, then implement that method
normally and the other method explicitly. This makes the default method to be accessible
through class instance.
 */

//using System;

//interface I1
//{
//    void InterfaceMethod();
//}
//interface I2
//{
//    void InterfaceMethod();
//}
//class Demo : I1, I2
//{
//    public void InterfaceMethod()
//    {
//        Console.WriteLine("I1 interface is implemented");
//    }
//    void I2.InterfaceMethod()
//    {
//        Console.WriteLine("I2 interface is implemented");
//    }
//    public static void Main()
//    {
//        Demo P = new Demo();
//        P.InterfaceMethod();
//        ((I2)P).InterfaceMethod();
//    }
//}