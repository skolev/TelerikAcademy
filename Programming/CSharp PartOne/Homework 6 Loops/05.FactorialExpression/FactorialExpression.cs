using System;
using System.Numerics;

class FactorialExpression
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if ((k > n) && (n > 1))
        {
            do
            {
                factorialN *= n;
                n--;
                factorialK *= k;
                k--;
            } while (n > 0);
            Console.WriteLine("N!*K! / (K-N)! = {0}", factorialK*factorialN);
        }
        else
        {
            Console.WriteLine("1<K<N !!!");
        }
    }
}    

