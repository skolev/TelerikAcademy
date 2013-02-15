using System;

class MaxSumSequence
{
    static void Main()
    {
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        int sum = 0; 
        int maxSum = int.MinValue;
        int sequenceStart = 0;
        int sequenceEnd = 0;
        int temp = 0;
        // Using Kadane's algorithm (source via wikipedia.org) with one loop.
        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
            if (sum > maxSum)
            {
                maxSum = sum;
                sequenceStart = temp;
                sequenceEnd = index;
            }
            if (sum < 0)
            {
                sum = 0;
                temp = index + 1;
            }
        }
        for (int i = sequenceStart; i <= sequenceEnd; i++)
        {
            Console.WriteLine("Array[{0}] = {1}", i, array[i]);
        }
    }
}
