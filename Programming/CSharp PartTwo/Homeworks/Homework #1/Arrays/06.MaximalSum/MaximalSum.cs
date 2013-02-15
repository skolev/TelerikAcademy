using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array lenght N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int maximalSum = int.MinValue;
        //int maxIndex;
        //int maxNumber;
        int[] array = new int[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        //DateTime start = DateTime.Now;
        //int[] copyArray = (int[])array.Clone();
        //List<int> positionList = new List<int>();

        //while (positionList.Count < k)
        //{
        //    maxIndex = 0;
        //    maxNumber = int.MinValue;
        //    for (int i = 0; i < copyArray.Length; i++)
        //    {
        //        if (copyArray[i] > maxNumber)
        //        {
        //            maxNumber = copyArray[i];
        //            maxIndex = i;
        //        }
        //    }
        //    positionList.Add(maxIndex);
        //    copyArray[maxIndex] = int.MinValue;
        //    //if (maxNumber < 0) break;
        //}
        ////Sorting elements according their position in the array
        //positionList.Sort();
        //Console.WriteLine("{0} elements with maximum sum are: ", k);
        //foreach (int number in positionList)
        //{
        //    maximalSum += array[number];
        //    Console.WriteLine("Array[{0}] = {1}",number,array[number]);
        //}
        //Console.WriteLine("with maximal sum = {0}",maximalSum);


        int sum = int.MinValue;
        int startIndex = 0;
        for (int index = 0; index <= array.Length - k; index++)
        {
            sum = array[index];

            for (int i = index + 1; i < index + k; i++)
            {
                sum += array[i];
            }
            if (sum > maximalSum)
            {
                maximalSum = sum;
                startIndex = index;
            }

        }
        for (int index = startIndex; index < startIndex + k; index++)
        {
            Console.WriteLine("Array[{0}] = {1}",index,array[index]);
        }
        Console.WriteLine(maximalSum);

    }
}