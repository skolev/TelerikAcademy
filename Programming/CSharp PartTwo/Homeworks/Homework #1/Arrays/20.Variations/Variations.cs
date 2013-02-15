using System;

class Variations
{
    //Used help from http://www.introprogramming.info/intro-csharp-book/read-online/glava10-rekursiq/
    static int k;
    static int n;
    static int[] elements;
    //Generates all the variations
    static void VariationRec(int currentLoop)
    {
            if (currentLoop == k)
            {
                //Prints current variation
                foreach (var digit in elements)
                {
                    Console.Write(digit + " ");
                }
                Console.WriteLine();
                  return;
            }
 
            for (int count = 1; count<=n; count++)
            {
                  elements[currentLoop] = count;
                  VariationRec(currentLoop + 1);
            }
     
    }
    static void Main()
    {
        Console.Write("Enter n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        k = int.Parse(Console.ReadLine());
        elements = new int[k];
        VariationRec(0);
    }
 
}    


