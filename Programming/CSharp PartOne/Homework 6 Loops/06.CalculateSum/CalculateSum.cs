using System;
using System.Numerics;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        double pow = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            pow = Math.Pow(x, i);
            sum += (factorial/(decimal)pow);
        }
        Console.WriteLine(sum);


    }
}    
