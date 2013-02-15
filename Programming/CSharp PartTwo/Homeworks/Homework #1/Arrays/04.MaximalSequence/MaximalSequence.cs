using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int index = 0; index < n; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }
        int sequence = 1;
        int maximalSequence = 1;
        int start = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                sequence++;

            }
            else
            {
                sequence = 1;
            }
            if (sequence > maximalSequence)
            {
                maximalSequence = sequence;
                start = i - (sequence-2);
            }
        }
        Console.WriteLine("Maximal sequence of equal elements:");
        for (int i = start; i < (start + maximalSequence); i++)
        {
            Console.WriteLine(array[i]);
        }


    }
}    
