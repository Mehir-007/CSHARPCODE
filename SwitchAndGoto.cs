using System;

class Demo
{
    public static void Main()
    {
        int TotalBill = 0;
    Start:
        Console.WriteLine("Enter coffee size small-1 , mid-2 ,large-3");
        int CoffeeChoice = int.Parse(Console.ReadLine());
        switch (CoffeeChoice)
        {
            case 1:
                TotalBill += 1;
                break;
            case 2:
                TotalBill += 2;
                break;
            case 3:
                TotalBill += 3;
                break;
            default:
                Console.WriteLine("Invalid Coffee Choice, Enter a correct size");
                goto Start;
        }
    ChooseAnother:
        Console.WriteLine("Do you want to buy another coffee? Enter Yes or No.");
        string buyanother = Console.ReadLine();
        switch (buyanother.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Enter Valid Choice");
                goto ChooseAnother;
        }
        Console.WriteLine("Thank You for shopping with us. Please pay the bill : ${0} at counter.", TotalBill);
    }
}