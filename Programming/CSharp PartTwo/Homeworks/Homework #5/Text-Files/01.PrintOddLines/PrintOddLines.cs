//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        // Create an instance of StreamReader to read from a file
        StreamReader reader = new StreamReader(@"..\..\..\Sample.txt");

        using (reader)
        {
            int lineNumber = 0;

            // Read first line from the text file
            string line = reader.ReadLine();

            // Read the other lines from the text file
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber % 2) != 0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}