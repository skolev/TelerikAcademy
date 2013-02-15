using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        int zeros = 0;
        int number = int.Parse(Console.ReadLine());
        int number1 = number;
        BigInteger factorial = 1;
        do
        {
            factorial *= number;
            number--;
        } while (number > 0);
        Console.WriteLine(factorial);
        if (number1 < 25)
        {
            zeros = number1 / 5;
        }
        else
        {
            zeros = (number1 / 5) + (number1 / 25);
        }
        Console.WriteLine(zeros);
    }
}    

