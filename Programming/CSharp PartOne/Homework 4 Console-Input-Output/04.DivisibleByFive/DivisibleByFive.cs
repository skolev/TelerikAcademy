using System;

class DivisibleByFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        uint startingNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        uint endingNumber = uint.Parse(Console.ReadLine());
        uint i;
        int counter = 0;

        for (i = startingNumber; i <= endingNumber; i++)
        {
            if ((i % 5) == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("There is/are {0} number/numbers from {1} to {2} divisible by 5", counter, startingNumber, endingNumber);
    }
}    

