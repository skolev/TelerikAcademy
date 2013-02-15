using System;
using System.IO;

class MaxPlatform
{
    //Finds thw max platform 2x2.
    static int GetMaximalSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        return bestSum;
    }
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\matrix.txt");
        using (reader)
        {
            //Creating and filling a matrix with given parameters and elements from file matrix.txt
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            string line = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                line = reader.ReadLine();
                string[] rows = line.Split(' ');
                for (int index = 0; index < matrix.GetLength(1); index++)
                {
                    matrix[i, index] = int.Parse(rows[index]);
                }
            }
            Console.WriteLine(GetMaximalSum(matrix));
        }


    }
}
