using System;

class SortsArrays
{
    static int GetArrayMaxValue(int[] arr, int begin)
    {
        int maxValueIndex = begin;
        int arrMaxValue = arr[maxValueIndex];
        for (int index = begin + 1; index < arr.Length; index++)
        {
            if (arrMaxValue < arr[index])
            {
                arrMaxValue = arr[index];
                maxValueIndex = index;
            }
        }
        return maxValueIndex;
    }
    static int[] ArraySort(int[] arr, bool sortingOrder)
    {
        //sorts array via selection sort.
        int valueSwap = int.MinValue;
        int posMaxValue = int.MinValue;
        for (int index = 0; index < arr.Length; index++)
        {
                valueSwap = arr[index];
                posMaxValue = GetArrayMaxValue(arr, index);
                arr[index] = arr[posMaxValue];
                arr[posMaxValue] = valueSwap;

        }
        //returns sorted array in descending order.
        if (sortingOrder)
        {
            return arr;
        }
        //returns sorted array in ascending order.
        else
        {   
            Array.Sort(arr);
            return arr;
        }
    }
    private static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] array = { 1, 4, 7, 8, 5, 2, 3, 6, 9 };
        PrintArray(array);
        bool sortOrder = true;
        int staringIndex = 5;
        //Prints max value in array from starting index.
        Console.WriteLine(GetArrayMaxValue(array,staringIndex));
        //Sorts array in descending order.
        array = ArraySort(array, sortOrder);
        PrintArray(array);

    }
}

