//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class WordReplace
{
    static void Main()
    {
        string start = "\\bstart\\b";
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
                    writer.WriteLine(Regex.Replace(line,start, finish));
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
