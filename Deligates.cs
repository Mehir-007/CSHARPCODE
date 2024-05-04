/*
In C#, delegates are a type that represents references to methods with a particular parameter list 
and return type. They are similar to function pointers in C and C++, but are type-safe and secure. 
Delegates are widely used in event handling and callback scenarios.
 */
using System;
using System.Collections.Generic;

public delegate void HelloFunctionDeligate(string Message);
class Demo
{
    public static void Main()
    {
        HelloFunctionDeligate del = new HelloFunctionDeligate(Hello);
        del("Hello Mehir");

    }
    public static void Hello(string Message)
    { Console.WriteLine(Message); }
}