using System;

class SequenceSum
{
    static void Main()
    {
        decimal firstSum = 1m;
        decimal secondSum = 0m;
        decimal sumCheck;
        decimal difference = 0.001m;
        int i = 2;
        do
        {
            if ((i % 2) == 0)
            {
                secondSum = (firstSum + (1m / i));
            }
            else
            {
                secondSum = (firstSum - (1m / i));
            }
            i++;
            sumCheck = (secondSum - firstSum);
            firstSum = secondSum;
        }
        while ((Math.Abs(sumCheck)) >= difference);
        Console.WriteLine(secondSum);
    }
}    

