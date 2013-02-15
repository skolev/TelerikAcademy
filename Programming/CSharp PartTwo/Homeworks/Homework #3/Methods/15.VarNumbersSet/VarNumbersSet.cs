using System;
using System.Numerics;

class VarNumbersSet
{
    static T FindMax<T>(params T[] arr)
    {
        dynamic maxNumber = arr[0];
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] > maxNumber)
            {
                maxNumber = arr[index];
            }
        }
        return maxNumber;
    }
    static T FindMin<T>(params T[] arr)
    {
        dynamic minNumber = arr[0];
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] < minNumber)
            {
                minNumber = arr[index];
            }
        }
        return minNumber;
    }
    static T FindAvg<T>(params T[] arr)
    {
        dynamic average = 0m;
        average = FindSum(arr) / (dynamic)arr.Length;
        return average;
    }
    static T FindSum<T>(params T[] arr)
    {
        dynamic sum = 0L;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static T FindProduct<T>(params T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Max: " + FindMax(1.1f, 2.5f, 3.14f, 1.8f, 5.86f, 10.156f, 16.5f));
        Console.WriteLine("Min: " + FindMin(1.1f, 2.5f, 3.14f, 1.8f, 5.86f, 10.156f, 16.5f));
        Console.WriteLine("Average: " + FindAvg(1.1f, 2.5f, 3.14f, 1.8f, 5.86f, 10.156f, 16.5f));
        Console.WriteLine("Sum: " + FindSum(1.1f, 2.5f, 3.14f, 1.8f, 5.86f, 10.156f, 16.5f));
        Console.WriteLine("Product: " + FindProduct(1.1f, 2.5f, 3.14f, 1.8f, 5.86f, 10.156f, 16.5f));

    }
}
