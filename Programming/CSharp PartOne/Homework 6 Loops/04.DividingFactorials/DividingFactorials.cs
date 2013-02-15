using System;
using System.Numerics;

class DividingFactorials
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        if ((n > k)&&(k > 1))
        {
            do
            {
                factorial *= n;
                n--;
            } while (n > k);
            Console.WriteLine("N!/K! = {0}",factorial );
        }
        else
        {
            Console.WriteLine("1<K<N !!!");
        }

    }
}    
