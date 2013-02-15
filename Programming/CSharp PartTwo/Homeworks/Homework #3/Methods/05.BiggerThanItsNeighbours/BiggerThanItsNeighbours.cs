using System;

class BiggerThanItsNeighbours
{
    static bool NumberCompareToHeighbours(int[] arr, int elementPosition)
    {
        //Checks if the number is bigger than its two neighbours
        if (((elementPosition == 0) && (arr[elementPosition] > arr[elementPosition + 1]))||
           ((elementPosition == arr.Length - 1) && (arr[elementPosition] > arr[elementPosition - 1]))||
           ((arr[elementPosition - 1] < arr[elementPosition]) && (arr[elementPosition] > arr[elementPosition + 1])))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        //Creating array for checking.
        Console.Write("Enter array lenght: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int index = 0; index < size; index++)
        {
            Console.Write("arr[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter position (0 - {0}): ",size -1);
        int numberPosition = int.Parse(Console.ReadLine());
        Console.Write("Is the number bigger than its two neighbours? ");
        Console.WriteLine(NumberCompareToHeighbours(array, numberPosition));
    }

}
