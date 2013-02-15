//Used the same code as in ex. 20, with some modifications.
using System;

class Combinations
{
    //Used help from http://www.introprogramming.info/intro-csharp-book/read-online/glava10-rekursiq/
    static int k;
    static int n;
    static int temp = 1;
    static int[] elements;
    //Generates all the variations
    static void CombinationRec(int currentIndex, int number)
    {
        if (currentIndex == k)
        {
            //Prints current variation
            foreach (var digit in elements)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            return;
        }

        for (int count = number ; count <= n; count++)
        {
            elements[currentIndex] = count;
            CombinationRec(currentIndex + 1, count + 1);
        }

    }
    static void Main()
    {
        Console.Write("Enter n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        k = int.Parse(Console.ReadLine());
        elements = new int[k];
        CombinationRec(0, 1);
    }
}
