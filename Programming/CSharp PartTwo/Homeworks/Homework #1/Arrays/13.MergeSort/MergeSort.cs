using System;

class MergeSort
{   //Merge sort
    static int[] MergeSorting(int[] num)
    {
        if (num.Length == 1)
        {
            return num;
        }
        int middle = num.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = num[i];
        }
        int[] right = new int[num.Length - middle];
        for (int i = 0; i < num.Length - middle; i++)
        {
            right[i] = num[i + middle];
        }
        left = MergeSorting(left);
        right = MergeSorting(right);

        int leftIndex = 0;
        int rightIndex = 0;

        int[] sorted = new int[num.Length];
        for (int k = 0; k < num.Length; k++)
        {
            if (rightIndex == right.Length || ((leftIndex < left.Length) && (left[leftIndex] <= right[rightIndex])))
            {
                sorted[k] = left[leftIndex];
                leftIndex++;
            }
            else if (leftIndex == left.Length || ((rightIndex < right.Length) && (right[rightIndex] <= left[leftIndex])))
            {
                sorted[k] = right[rightIndex];
                rightIndex++;
            }
        }
        return sorted;
    }
    static void Main()
    {
        int[] numbers = { 9, 8, 7, 4, 1, 2, 3, 6, 5 };
        int[] sortedNum = MergeSorting(numbers);
        //Prints sorted array.
        foreach (var num in sortedNum)
        {
            Console.WriteLine(num);
        }
    }
}
