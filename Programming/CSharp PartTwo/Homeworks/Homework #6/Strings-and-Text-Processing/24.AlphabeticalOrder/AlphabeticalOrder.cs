/*Write a program that reads a list of words, separated by 
 * spaces and prints the list in an alphabetical order.
 */
using System;
using System.Collections.Generic;

class AlphabeticalOrder
{
    static void QuickSorting(string[] a, int left, int right)
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
            while (a[i].CompareTo(middle) < 0)
            {
                i++;
                leftString = a[i];
            }
            while (a[j].CompareTo(middle) > 0)
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
        char[] separators = new char[] { ' ' };
        //Test string.
        string enteredString = " telerik academy seal alpha bird cat dog flight";
        string[] unsorted = enteredString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        QuickSorting(unsorted, 0, unsorted.Length - 1);
        foreach (var str in unsorted)
        {
            Console.WriteLine(str);
        }
    }
}
