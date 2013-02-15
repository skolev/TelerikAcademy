using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 };
        int number = 10;
        int startIndex = 0;
        int endIndex = arr.Length - 1;
        int inTheMiddle = 0;

        while (startIndex <= endIndex)
        {
            inTheMiddle = (startIndex + endIndex) / 2;
            if (arr[inTheMiddle] > number)
            {
                endIndex = inTheMiddle - 1;
            }
            else if (arr[inTheMiddle] < number)
            {
                startIndex = inTheMiddle + 1;
            }
            else
            {
                Console.WriteLine(inTheMiddle);
                break;
            }

        }

    }
}
