/*Write a program that deletes from given text file all 
 * odd lines. The result should be in the same file.
 */

using System;
using System.Collections.Generic;
using System.IO;

class DeleteLines
{
    static void Main()
    {
        //Getting the names from file in a List of strings
        List<string> lines = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\lines.txt");

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber % 2) == 0)
                {
                    lines.Add(line);
                }
                line = reader.ReadLine();
            }
        }
        //Write the list into a file.
        StreamWriter writer = new StreamWriter(@"..\..\lines.txt", false);

        using (writer)
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}
