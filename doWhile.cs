using System;

class Demo
{
    public static void Main()
    {
        string ans = "";
        do
        {
            Console.WriteLine("Enter the range for list of even numberes");
            int x = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= x)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
                i++;
            }
            do
            {
                Console.WriteLine("Do you want to continue for another range? Enter Yes or No");
                ans = Console.ReadLine().ToUpper();
                if (ans != "YES" && ans != "NO")
                {
                    Console.WriteLine("Enter Valid Input");
                }

            } while (ans != "YES" && ans != "NO");
        } while (ans == "YES");
    }
}