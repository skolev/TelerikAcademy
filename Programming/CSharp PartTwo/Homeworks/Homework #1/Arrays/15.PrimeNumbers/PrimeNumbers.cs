using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        //int numberRange = 10000000;
        //For different range:
        Console.Write("Enter a range 1 - ");
        int numberRange = int.Parse(Console.ReadLine());
        List<int> rangeList = new List<int>();
        for (int i = 2; i <= numberRange; i++)
			{
                rangeList.Add(i);
			}
        for (int i = 0; i < rangeList.Count ; i++)
        {
            if (rangeList[i] == 0)
            {
                continue;
            }
            for (int index = i + rangeList[i]; index < rangeList.Count; index+=rangeList[i])
            {
                rangeList[index] = 0;
            }
            
        }
        rangeList.RemoveAll(num => num == 0);
        //All the prime number from the range are now in rangeList
        //Remove the comment for foreach loop to print them all.

        foreach (var prime in rangeList)
        {
            Console.Write("{0} ", prime);
            Console.WriteLine();
        }
        Console.WriteLine("In the range [1 - {0}] there are {1} prime numbers",numberRange, rangeList.Count);
    }
}    

