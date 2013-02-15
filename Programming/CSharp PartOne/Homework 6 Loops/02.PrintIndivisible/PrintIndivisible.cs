using System;

class PrintIndivisible
{
    static void Main()
    {
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        for (int number = 1; number <= n; number++)
        {
            if ((number % 3 == 0) || (number % 7 == 0))
            {
                continue;
            }
            Console.WriteLine(number);
        }
    }
}    

