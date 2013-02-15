using System;

class MatrixC
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        // Allocate the matrix
        int[,] intMatrix = new int[n, n];
        int number = 1;
        int colLoops = 0;

        //Filling matrix elements
        for (int row = n - 1; row >= 0; row--)
        {
            for (int i = 0; i <= colLoops; i++)
			{
                intMatrix[row + i, i] = number;
                number++;
			}
            colLoops++;
        }
        colLoops--;
        for (int col = 1; col < intMatrix.GetLength(1); col++)
        {
            for (int i = 0; i < colLoops; i++)
            {
                intMatrix[i, col + i] = number;
                number++;
            }
            colLoops--;
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
