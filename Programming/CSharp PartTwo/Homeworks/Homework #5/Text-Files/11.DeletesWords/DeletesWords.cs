/*Write a program that deletes from a text file all 
 * words that start with the prefix "test". Words 
 * contain only the symbols 0...9, a...z, A…Z, _.
 */


using System;
using System.IO;
using System.Text.RegularExpressions;

class DeletesWords
{
    static void Main()
    {
        string start = @"\btest\w*\b";
        string finish = "";
        StreamWriter writer = new StreamWriter(@"..\..\test1.txt");
        using (writer)
        {
            StreamReader readerOne = new StreamReader(@"..\..\test.txt");
            using (readerOne)
            {
                string line = readerOne.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, start, finish));
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
