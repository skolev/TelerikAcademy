using System;

class CompareTwoArrays
{
    static void Main()
    {
        bool arrayCompare = true;
        Console.WriteLine("Enter first array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        Console.WriteLine("Enter first array: ");
        for (int index = 0; index < n; index++)
        {
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array lenght: ");
        int m = int.Parse(Console.ReadLine());
        int[] secondArray = new int[m];
        Console.WriteLine("Enter first array: ");
        for (int index = 0; index < m; index++)
        {
            secondArray[index] = int.Parse(Console.ReadLine());
        }
        if (n == m)
        {
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    arrayCompare = false;
                    break;
                }
            }
        }
        else
        {
            arrayCompare = false;
        }

        Console.WriteLine("Two arrays are equal? {0}", arrayCompare);
        


    }
}    

