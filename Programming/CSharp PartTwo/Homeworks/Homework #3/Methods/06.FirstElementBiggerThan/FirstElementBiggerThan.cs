using System;

class FirstElementBiggerThan
{
    static int FindFirstElement(int[] arr)
    {
        //Checks if the number is bigger than its two neighbours
        //Number it's the first in the array
        if (arr[0] > arr[1])
        {
            return 0;
        }
        //Number is somewhere in the array (not at first or last position).
        for (int index = 1; index < arr.Length - 1; index++)
        {
            if ((arr[index - 1] < arr[index]) && (arr[index] > arr[index + 1]))
            {
                return index;
            }
        }
        //Number it's the last in the array
        if (arr[arr.Length - 1]>arr[arr.Length - 2])
        {    
            return arr.Length - 1;
        }    
        return -1;
    }
    static void Main()
    {
        int[] array = {1, 2, 3, 4, 4};
        // Prints the index of the element (0 - size), of -1 if there's no such element.
        Console.WriteLine(FindFirstElement(array));
    }

}
