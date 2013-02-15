/*Write a program that compares two text files line by
 * line and prints the number of lines that are the same
 * and the number of lines that are different. Assume 
 * the files have equal number of lines.
 */

using System;
using System.IO;

class LineByLine
{
    static void Main()
    {

        StreamReader readerOne = new StreamReader(@"..\..\first.txt");
        using (readerOne)
        {
            int equalLines = 0;
            int totalLines = 0;
            StreamReader readerTwo = new StreamReader(@"..\..\second.txt");
            using (readerTwo)
            {
                //Read the the first line in both files
                string firstFileLine = readerOne.ReadLine();
                string secondFileLine = readerTwo.ReadLine();
                while ((secondFileLine != null) && (firstFileLine != null))
                {
                    totalLines++;
                    //Comares the lines of the files.
                    if (firstFileLine == secondFileLine)
                    {
                        equalLines++;
                    }
                    //Read next lines.
                    firstFileLine = readerOne.ReadLine();
                    secondFileLine = readerTwo.ReadLine();
                }
                //Checks if the two files have same amount ot lines.
                if (secondFileLine == null && firstFileLine == null)
                {
                    Console.WriteLine("{0} lines are the same, and {1} lines are different", equalLines, (totalLines - equalLines));
                }
                else
                {
                    Console.WriteLine("The two files have different number of lines");
                } 
            }
        }
    }
}
