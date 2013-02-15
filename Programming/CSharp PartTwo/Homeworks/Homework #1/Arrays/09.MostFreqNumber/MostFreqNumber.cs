using System;
using System.Collections.Generic;

class MostFreqNumber
{
    static void Main()
    {
        //Following code works properly if the most frequent number is only one.
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        int minNumber;
        int swapNumbers;

        for (int index = 0; index < arr.Length; index++)
        {
            minNumber = index;

            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[minNumber] > arr[i])
                {
                    minNumber = i;
                }
            }

            swapNumbers = arr[minNumber];
            arr[minNumber] = arr[index];
            arr[index] = swapNumbers;
        }
        int currentNumber = arr[0];
        int freqCounter = 1;
        int maxFreqCounter = 1;
        int maxFreqNumber = 1;
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] == currentNumber)
            {
                freqCounter++;
            }
            else 
            {
                freqCounter = 1;
            }
            if (maxFreqCounter < freqCounter)
            {
                maxFreqCounter = freqCounter;
                maxFreqNumber = currentNumber;
            }

            currentNumber = arr[index];
        }
        Console.WriteLine("Most frequent number is: {0} ({1} times)", maxFreqNumber, maxFreqCounter);
    }
}    

