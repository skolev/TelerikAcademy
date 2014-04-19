using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithms
{
    public class AlgorithmsPerformance
    {
        public static void TestingIntegerArray(int[] array)
        {
            Console.Write("Insertion sort:\t");
            DisplayExecutionTime(() =>
            { 
                InsertionSort.InsertionSortArray((int[])array.Clone()); 
            });

            Console.Write("Selection sort:\t");
            DisplayExecutionTime(() =>
            { 
                SelectionSort.SelectionSortArray((int[])array.Clone());
            });

            Console.Write("Quicksort sort:\t");
            DisplayExecutionTime(() =>
            { 
                QuickSort.QuickSortArray((int[])array.Clone(), 0, array.Length - 1); 
            });
        }

        public static void TestingDoubleArray(double[] array)
        {
            Console.Write("Insertion sort:\t");
            DisplayExecutionTime(() =>
            { 
                InsertionSort.InsertionSortArray((double[])array.Clone()); 
            });

            Console.Write("Selection sort:\t");
            DisplayExecutionTime(() =>
            { 
                SelectionSort.SelectionSortArray((double[])array.Clone());
            });

            Console.Write("Quicksort sort:\t");
            DisplayExecutionTime(() =>
            { 
                QuickSort.QuickSortArray((double[])array.Clone(), 0, array.Length - 1);
            });
        }

        public static void TestingStringArray(string[] array)
        {
            Console.Write("Insertion sort:\t");
            DisplayExecutionTime(() =>
            { 
                InsertionSort.InsertionSortArray((string[])array.Clone());
            });

            Console.Write("Selection sort:\t");
            DisplayExecutionTime(() =>
            { 
                SelectionSort.SelectionSortArray((string[])array.Clone());
            });

            Console.Write("Quicksort sort:\t");
            DisplayExecutionTime(() =>
            { 
                QuickSort.QuickSortArray((string[])array.Clone(), 0, array.Length - 1);
            });
        }

        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main()
        {
            Random randomNumber = new Random();
            int[] intArray = new int[20000];
            int len = intArray.Length;

            for (int i = 0; i < len; i++)
            {
                intArray[i] = randomNumber.Next(1, 20001);
            }

            int[] intArraySorted = intArray.OrderBy(x => x).ToArray();
            int[] intArrayReversed = intArray.OrderByDescending(x => x).ToArray();

            Console.WriteLine("Unsorted integer array:");
            TestingIntegerArray(intArray);
            Console.WriteLine();
            Console.WriteLine("Sorted integer array:");
            TestingIntegerArray(intArraySorted);
            Console.WriteLine();
            Console.WriteLine("Sorted in reverse order integer array:");
            TestingIntegerArray(intArrayReversed);
            Console.WriteLine();

            double[] doubleArray = new double[20000];
            for (int i = 0; i < len; i++)
            {
                doubleArray[i] = randomNumber.Next(1, 20001) + randomNumber.NextDouble();
            }

            double[] doubleArraySorted = doubleArray.OrderBy(x => x).ToArray();
            double[] doubleArrayReversed = doubleArray.OrderByDescending(x => x).ToArray();

            Console.WriteLine("Unsorted double array:");
            TestingDoubleArray(doubleArray);
            Console.WriteLine();
            Console.WriteLine("Sorted double array:");
            TestingDoubleArray(doubleArraySorted);
            Console.WriteLine();
            Console.WriteLine("Sorted in reverse order double array:");
            TestingDoubleArray(doubleArrayReversed);
            Console.WriteLine();

            string[] stringArray = new string[20000];
            for (int i = 0; i < len; i++)
            {
                stringArray[i] = i.ToString();
            }

            string[] stringArraySorted = stringArray.OrderBy(x => x).ToArray();
            string[] stringArrayReversed = stringArray.OrderByDescending(x => x).ToArray();

            Console.WriteLine("Unsorted string array:");
            TestingStringArray(stringArray);
            Console.WriteLine();
            Console.WriteLine("Sorted string array:");
            TestingStringArray(stringArraySorted);
            Console.WriteLine();
            Console.WriteLine("Sorted in reverse order string array:");
            TestingStringArray(stringArrayReversed);
            Console.WriteLine();
        }
    }
}
