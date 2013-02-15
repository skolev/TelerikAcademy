using System;

class MinAndMax
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int maxValue = 0;
        int minValue = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > maxValue)
            {
                maxValue = number;
            }
            else if (number < minValue)
            {
                minValue = number;
            }
            
        }

        Console.WriteLine("Maximal number: {0}, minimal number: {1}",maxValue,minValue);
    }
}    

