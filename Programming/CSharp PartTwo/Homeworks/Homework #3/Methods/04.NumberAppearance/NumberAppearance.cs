using System;

class NumberAppearance
{
    static int GetNumberAppearances(int[] arr, int number)
    {
        int appearanceCounter = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] == number)
            {
                appearanceCounter++;
            }
        }
        return appearanceCounter;
    }
    static void Main()
    {
        //Enters input parameters: number to check for, array
        Console.Write("Enter a number to check: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        Console.Write("Number of elements = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int index = 0; index < size; index++)
        {
            Console.Write("arr[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number {0} is appearing: ", numberToCheck);
        Console.WriteLine(GetNumberAppearances(array,numberToCheck));
    }

}
