using System;

class GivenSum
{
    static void Main()
    {
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.Write("Enter S: ");
        int sum = int.Parse(Console.ReadLine());
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        int sumCheck = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;
        for (int index = 0; index < array.Length; index++)
        {   
            sumCheck = array[index];
            startIndex = index;
            for (int i = index + 1; i < array.Length; i++)
            {
                sumCheck += array[i];
                if (sumCheck == sum)
                {
                    endIndex = i;
                    break;
                }

            }
            if (sumCheck == sum)
            {
                break;
            }
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.WriteLine("Array[{0}] = {1}", i, array[i]);
        }
    }
}    

