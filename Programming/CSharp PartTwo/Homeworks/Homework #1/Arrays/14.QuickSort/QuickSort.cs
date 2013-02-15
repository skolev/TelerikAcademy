using System;
using System.Collections.Generic;

class QuickSort
{
    static void QuickSorting(List<string> a, int left, int right)
        {
            int i = left;
            int j = right;
            string leftString = a[i];
            string rightString = a[j];
            double pivotValue = ((left + right) / 2);
            string middle = a[(int)(pivotValue)];
            string temp = string.Empty;
            while (i <= j)
            {
                while(a[i].CompareTo(middle) < 0)
                {
                    i++;
                    leftString = a[i];
                }
                while(a[j].CompareTo(middle) > 0)
                {
                    j--;
                    rightString = a[j];
                }
                if (i <= j)
                {
                    temp = a[i];
                    a[i++] = a[j];
                    a[j--] = temp;
                }
            }
            if (left < j)
            {
                QuickSorting(a, left, j);
            }
            if (i < right)
            {
                QuickSorting(a, i, right);
            }
        }
    static void Main()
    {
        List<string>unsorted = new List<string>{ "d", "e", "f", "c", "m", "x", "a", "s", "w", "l"};
        QuickSorting(unsorted, 0, unsorted.Count - 1);
        foreach (var str in unsorted)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}
