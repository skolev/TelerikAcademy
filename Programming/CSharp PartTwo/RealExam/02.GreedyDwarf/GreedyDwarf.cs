using System;
using System.Collections.Generic;

class GreedyDwarf
{
    static int CoinsCounter(int[] numbers, int[] patternValues)
    {
        int i = 0;
        List<int> visited = new List<int>();
        int patternCoins = numbers[i];
        visited.Add(i);

        while (true)
        {
            for (int index = 0; index < patternValues.Length; index++)
            {
                if ((i + patternValues[index]) > numbers.Length - 1 || i + patternValues[index] < 0 || visited.Contains((i + patternValues[index])))
                {
                    return patternCoins;
                }
                else
                {
                    patternCoins += numbers[i + patternValues[index]];
                    i += patternValues[index];
                    visited.Add(i);
 
                }
            }

        }


    }
    static void Main()
    {
        char[] separators = new char[] { ' ', ',' };
        string str = Console.ReadLine();
        short patternCount = short.Parse(Console.ReadLine());
        int maxCoins = int.MinValue;
        int coins = 0;
        string[] values = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[values.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(values[i]);
        }
        int[][] patterns = new int[patternCount][];
        for (int i = 0; i < patternCount; i++)
        {
            str = Console.ReadLine();
            string[] pattern = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            patterns[i] = new int[pattern.Length];
            for (int index = 0; index < pattern.Length; index++)
            {
                patterns[i][index] = int.Parse(pattern[index]);
            }
        }
        for (int i = 0; i < patternCount; i++)
        {
            coins = CoinsCounter(numbers, patterns[i]);
            if (maxCoins < coins)
            {
                maxCoins = coins;
            }
        }
        Console.WriteLine(maxCoins);
    }
}     
