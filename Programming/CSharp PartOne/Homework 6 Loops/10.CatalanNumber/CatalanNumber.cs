using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial1 = 1;
        BigInteger factorial2 = 1;
        int number;
        for (int i = 1; i <= 2*n; i++)
        {
            if (i < (n + 1))
            {
                factorial1 *= i;
            }
            if (i == n+1)
            {
                continue;
            }
            if (i > (n + 1))
            {
                factorial2 *= i;
            }
        }
        number =(int)factorial2 / (int)factorial1;
        Console.WriteLine("Catalan Number is: {0}", number);
    }
}    

