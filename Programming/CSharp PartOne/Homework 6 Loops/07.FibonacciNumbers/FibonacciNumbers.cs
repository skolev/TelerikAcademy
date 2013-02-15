using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum = secondNumber;
        if (n > 0)
        {
            Console.WriteLine("{0,3} |{1}", sum, firstNumber);
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("{0,3} |{1}", i, sum);
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
    }
}    

