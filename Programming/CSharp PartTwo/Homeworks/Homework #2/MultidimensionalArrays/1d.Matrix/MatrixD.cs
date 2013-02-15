using System;

class MatrixD
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        // Allocate the matrix
        int[,] intMatrix = new int[n, n];
        int matrixIndex = n - 1;
        int number = 1;
        int startIndex = 0;

        //Filling matrix elements
        while (number <= n*n)
        {
            for (int row = startIndex; row <= matrixIndex; row++)
            {
                intMatrix[row, startIndex] = number;
                number++;
            }
            for (int col = startIndex + 1; col <= matrixIndex; col++)
            {
                intMatrix[matrixIndex, col] = number;
                number++;
            }
            for (int row = matrixIndex - 1; row >= startIndex; row--)
            {
                intMatrix[row, matrixIndex] = number;
                number++;
            }
            for (int col = matrixIndex - 1; col > startIndex; col--)
            {
                intMatrix[startIndex, col] = number;
                number++;
            }

            startIndex++;
            matrixIndex--;

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
