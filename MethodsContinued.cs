/*
PassByReferance - Any changes done to the parameters will reflect in the argument
PassByValue - Any changes done to the parameters will not reflect in the argument
*/
using System;

class Demo
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;

        //Pass By Referance
        int passAsRef = 10;
        Console.WriteLine("Original Number {0}", passAsRef);
        PassByReferance(ref passAsRef);
        Console.WriteLine("Number after passing it as referance {0}", passAsRef);
        //Pass By Referance

        // Pass By Value
        int passAsVal = 20;
        Console.WriteLine("Original Number {0}", passAsVal);
        PassByValue(passAsVal);
        Console.WriteLine("Number after passing it as value {0}", passAsVal);
        //Pass By Value

        //Out Parameters :: Used for returning two values 
        SumAndProduct(10, 20, out Total, out Product);
        Console.WriteLine("Output 1 (SUM) using out Parameters : {0}", Total);
        Console.WriteLine("Output 2 (PRODUCT) using out Parameters : {0}", Product);
        //Out Parameters :: User for returning two values

        /*
        Arrays And Methods:
            1.Array bu default is passed by referance
            2.Parameter array can be used by using params keyword
                Parameter array can be passed or not passed during function call which is the actual use of it.
                Paramter array must be the last paramter in the funtion defination.
                There can only be one parameter array in the function.
        */
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        char[] character = { 'a', 'b', 'c', 'd', 'e', 'f' };
        Console.WriteLine("number[0] before function call : {0} , character[0] before function call : {1}.", numbers[0], character[0]);
        ArrayManipulation(numbers, character);
        Console.WriteLine("number[0] after function call : {0} , character[0] after function call : {1}.Hence array is paased by referance by default", numbers[0], character[0]);

        int[] ParaArray = { 1, 2 };
        ParameterArray(ParaArray);

        //Arrays And Methods
    }
    public static void PassByReferance(ref int AsRef)
    {
        AsRef = 100;
    }
    public static void PassByValue(int passAsVal)
    {
        passAsVal = 200;
    }
    public static void SumAndProduct(int Fn, int Ln, out int Sum, out int Product)
    {
        Sum = Fn + Ln;
        Product = Fn * Ln;
    }
    public static void ArrayManipulation(int[] numbers, char[] characters)
    {
        numbers[0] = 10;
        characters[0] = 'z';
    }
    public static void ParameterArray(params int[] ParaArray)
    {
        Console.WriteLine("Parameter array size : {0}", ParaArray.Length);
    }
}