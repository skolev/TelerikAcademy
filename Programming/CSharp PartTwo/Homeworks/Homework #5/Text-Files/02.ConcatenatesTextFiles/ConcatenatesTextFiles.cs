//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenatesTextFiles
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"..\..\third.txt", false);
        using (writer)
        {
            StreamReader readerOne = new StreamReader(@"..\..\first.txt");
            using (readerOne)
            {
                string line = readerOne.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = readerOne.ReadLine();
                }
            }
            StreamReader readerTwo = new StreamReader(@"..\..\second.txt");
            using (readerTwo)
            {
                string line = readerTwo.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = readerTwo.ReadLine();
                }
            }
        }

    }
}
