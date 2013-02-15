/*Write a program that reads a text file and inserts line 
 * numbers in front of each of its lines. The result 
 * should be written to another text file.
 */

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"..\..\result.txt", false);
        using (writer)
        {
            StreamReader reader = new StreamReader(@"..\..\..\Sample.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writer.Write(lineNumber + ". ");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
           
        }
    }
}
