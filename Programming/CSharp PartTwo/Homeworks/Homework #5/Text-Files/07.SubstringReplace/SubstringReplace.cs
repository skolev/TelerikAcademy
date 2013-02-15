/*Write a program that replaces all occurrences of the substring "start" with the
 * substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;

class SubstringReplace
{
    static void Main()
    {
        string start = "start";
        string finish = "finish";
        StreamWriter writer = new StreamWriter(@"..\..\test1.txt");
        using (writer)
        {
            StreamReader readerOne = new StreamReader(@"..\..\test.txt");
            using (readerOne)
            {
                string line = readerOne.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line.Replace(start,finish));
                    line = readerOne.ReadLine();
                }
            }
        }
        //Replace files and deleting unnecessary files.
        File.Replace(@"..\..\test1.txt", @"..\..\test.txt", @"..\..\testbackup.txt");
        File.Delete(@"..\..\testbackup.txt");
        File.Delete(@"..\..\test1.txt");
    }
}
