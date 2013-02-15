using System;

class SequenceEqualStrings
{
    static void Main()
    {
        // Declare and initialize the matrix
        string[,] strMatrix = 
        {
            {"ha", "fifi", "xxx", "hi"},
            {"fo", "xxx", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
        };
        //string[,] strMatrix =
        //{
        //     {"s", "qq", "pp"},
        //     {"pp", "pp", "s"},
        //     {"pp", "qq", "s"},
        //};

        int rowIndex = 0;
        int colIndex = 0;
        int bestSeq = 0;
        int bestRow = 0;
        int bestCol = 0;
        int seq = 1;

        // Find the max sequence equal strings ( works if it's only one).
        for (int row = 0; row < strMatrix.GetLength(0); row++)
        {   
            rowIndex = row;
            for (int col = 0; col < strMatrix.GetLength(1); col++)
            {

                colIndex = col;
                if((row + 1) < strMatrix.GetLength(0))
                {
                    while ((rowIndex + 1 < strMatrix.GetLength(0))&&(strMatrix[rowIndex, col] == strMatrix[rowIndex + 1, col]))
                    {
                        seq++;
                        rowIndex++;
                    }
                    if (bestSeq < seq)
                    {
                        bestSeq = seq;
                        bestRow = row;
                        bestCol = col;
                    }
                    else seq = 1;

                }
                if ((col + 1) < strMatrix.GetLength(1))
                {
                    while ((colIndex + 1 < strMatrix.GetLength(1))&&(strMatrix[row, colIndex] == strMatrix[row, colIndex + 1]))
                    {
                        seq++;
                        colIndex++;
                    }
                    if (bestSeq < seq)
                    {
                        bestSeq = seq;
                        bestRow = row;
                        bestCol = col;
                    }
                    else seq = 1;
                }
                if (((row + 1) < strMatrix.GetLength(0))&&((col + 1) < strMatrix.GetLength(1)))
                {
                    while ((colIndex + 1 < strMatrix.GetLength(1)) && (rowIndex + 1 < strMatrix.GetLength(0)) &&
                        (strMatrix[rowIndex, colIndex] == strMatrix[rowIndex + 1, colIndex + 1]))
                    {
                        seq++;
                        rowIndex++;
                        colIndex++;
                    }
                    if (bestSeq < seq)
                    {
                        bestSeq = seq;
                        bestRow = row;
                        bestCol = col;
                    }
                    else seq = 1;
                } 
                
                if (((row + 1) < strMatrix.GetLength(0)) && ((col - 1) >= 0))
                {
                    while ((colIndex - 1 >= 0) && (rowIndex + 1 < strMatrix.GetLength(0)) &&
                        (strMatrix[rowIndex, colIndex] == strMatrix[rowIndex + 1, colIndex - 1]))
                    {
                        seq++;
                        rowIndex++;
                        colIndex--;
                    }
                    if (bestSeq < seq)
                    {
                        bestSeq = seq;
                        bestRow = row;
                        bestCol = col;
                    }
                    else seq = 1;
                }
                seq = 1;


            }
        }
        for (int i = 0; i < bestSeq; i++)
			{
			  Console.Write("{0} ",strMatrix[bestRow,bestCol]);
			}
        Console.WriteLine();

    }

}
