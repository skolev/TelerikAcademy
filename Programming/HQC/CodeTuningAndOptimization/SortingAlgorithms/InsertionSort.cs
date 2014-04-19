using System;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void InsertionSortArray<T>(T[] array) where T : IComparable<T>
        {
            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                T value = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = value;
            }  
        }
    }
}
