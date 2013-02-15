using System;

class LargestNumberLessThan
{
    static void Main()
    {
        //Enter array and K.
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        //Sort the array.
        Array.Sort(arr);

        //Prints sorted array
        foreach (var num in arr)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();

        //Array.BinarySearch() finds the largest number in the array which is ≤ K. 
        int numberIndex = Array.BinarySearch(arr, k);
        if (numberIndex < 0)
        {
            Console.WriteLine("The number {0} is not found. The next larger number is {1} at index {2}",
                                                            k, arr[~numberIndex - 1], ~numberIndex - 1);
        }
        else
        {
            Console.WriteLine("The number {0} is at index {1}.", k, numberIndex);
        }

    }
}
