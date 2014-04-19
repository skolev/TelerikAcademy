using System;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void SelectionSortArray<T>(T[] array) where T : IComparable<T>
        {
            int minNumberIndex;

            for (int index = 0; index < array.Length; index++)
            {
                minNumberIndex = index;

                for (int i = index + 1; i < array.Length; i++)
                {
                    if (array[i].CompareTo(array[minNumberIndex]) < 0)
                    {
                        minNumberIndex = i;
                    }
                }

                Swap(ref array[index], ref array[minNumberIndex]);
            }
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
