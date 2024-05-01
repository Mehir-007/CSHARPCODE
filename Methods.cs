/*There are two types of methods:
1.Static Methods can be called without creating an object.
2.Instance Methods should be called by creating an object.
*/
/*
NOTE: 
Static functions are member functions of a class that are associated with the class itself
rather than with an instance or object of the class. This means that a static function can be 
called without creating an instance of the class.
*/
using System;

class Demo
{
    public static void Main()
    {
        Demo p = new Demo();
        p.PrintEven();

        Demo.PrintOdd();
    }
    //Instance Method
    public void PrintEven()
    {
        int x = 10;
        int i = 0;
        while (i <= x)
        {
            Console.Write(i + " ");
            i += 2;
        }
        Console.WriteLine();
    }
    //Static Method
    public static void PrintOdd()
    {
        int x = 10;
        int i = 1;
        while (i <= x)
        {
            Console.Write(i + " ");
            i += 2;
        }
    }
}