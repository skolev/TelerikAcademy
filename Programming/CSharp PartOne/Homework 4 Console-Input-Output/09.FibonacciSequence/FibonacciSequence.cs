using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum;
        int i = 1;
        Console.WriteLine("{0,3} |{1,21}", i, firstNumber);
        Console.WriteLine("{0,3} |{1,21}", ++i, secondNumber);
        do
        {
            i++;
            sum = firstNumber + secondNumber;
            Console.WriteLine("{0,3} |{1,21}", i, sum);
            firstNumber = secondNumber;
            secondNumber = sum;
        }
        while (i < 100);
        Console.Write("...");
        Console.WriteLine();
    }
}    

