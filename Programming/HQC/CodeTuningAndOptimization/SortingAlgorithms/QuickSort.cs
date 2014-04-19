using System;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void QuickSortArray<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int i = left;
            int j = right;
            T leftValue = array[i];
            T rightValue = array[j];
            double pivotValue = (left + right) / 2;
            T middle = array[(int)pivotValue];
            T temp;
            while (i <= j)
            {
                while (array[i].CompareTo(middle) < 0)
                {
                    i++;
                    leftValue = array[i];
                }

                while (array[j].CompareTo(middle) > 0)
                {
                    j--;
                    rightValue = array[j];
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i++] = array[j];
                    array[j--] = temp;
                }
            }

            if (left < j)
            {
                QuickSortArray(array, left, j);
            }

            if (i < right)
            {
                QuickSortArray(array, i, right);
            }
        }
    }
}
