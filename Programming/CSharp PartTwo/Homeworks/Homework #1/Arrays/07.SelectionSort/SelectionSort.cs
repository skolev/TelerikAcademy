using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        int minNumber;
        int swapNumbers;

        for (int index = 0; index < array.Length; index++)
        {
            minNumber = index;

            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[minNumber] > array[i])
                {
                    minNumber = i;
                }
            }

            swapNumbers = array[minNumber];
            array[minNumber] = array[index];
            array[index] = swapNumbers;

        }
        int position = 0;
        foreach (var number in array)
        {
            Console.WriteLine("Array[{0}] = {1}", position, number);
            position++;
        }
    }
}    

