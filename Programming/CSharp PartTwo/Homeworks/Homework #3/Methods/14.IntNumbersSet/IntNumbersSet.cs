using System;
using System.Numerics;

class IntNumbersSet
{
    static int FindMax(int[] arr)
    {
        int maxNumber = arr[0];
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] > maxNumber)
            {
                maxNumber = arr[index];
            }
        }
        return maxNumber;
    }
    static int FindMin(int[] arr)
    {
        int minNumber = arr[0];
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index] < minNumber)
            {
                minNumber = arr[index];
            }
        }
        return minNumber;
    }
    static decimal FindAvg(int[] arr)
    {
        decimal average = 0m;
        average = FindSum(arr) / (decimal)arr.Length;
        return average;
    }
    static long FindSum(int[] arr)
    {
        long sum = 0L;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static BigInteger FindProduct(int[] arr)
    {
        BigInteger product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }

    static void Main()
    {
        Console.Write("Enter a set of int numbers: ");
        string enteredSet = Console.ReadLine();
        string[] arr = enteredSet.Split(' ', ',');
        int[] numbersSet = new int[arr.Length];    
        for (int i = 0; i < arr.Length; i++)
        {
            numbersSet[i] = int.Parse(arr[i]);
        }
        Console.WriteLine("Max: " + FindMax(numbersSet));
        Console.WriteLine("Min: " + FindMin(numbersSet));
        Console.WriteLine("Average: " + FindAvg(numbersSet));
        Console.WriteLine("Sum: " + FindSum(numbersSet));
        Console.WriteLine("Product: " + FindProduct(numbersSet));

    }
}    

