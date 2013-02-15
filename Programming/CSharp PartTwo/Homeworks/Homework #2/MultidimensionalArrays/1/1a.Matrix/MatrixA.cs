using System;
using System.Linq;

class MatrixA
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        // Allocate the matrix
        int[,] intMatrix = new int[n, n];
        int number = 1;

        //Filling matrix elements
        for (int col = 0; col < intMatrix.GetLength(1); col++)
        {
            for (int row = 0; row < intMatrix.GetLength(0); row++)
            {
                intMatrix[row, col] = number;
                number++;
            }
        }
        //Print matrix
        for (int row = 0; row < intMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < intMatrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", intMatrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}    

