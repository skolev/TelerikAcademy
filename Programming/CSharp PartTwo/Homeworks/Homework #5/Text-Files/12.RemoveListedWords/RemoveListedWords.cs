/*Write a program that removes from a text file all
 * words listed in given another text file. Handle all 
 * possible exceptions in your methods.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveListedWords
{
    //Add \b at the begining, and at the end of the string. To search for the whole word.
    static string GetWordsRegularExpressions(string word)
    {
        string str = "\\b";
        StringBuilder sb = new StringBuilder();
        sb.Append(str);
        sb.Append(word);
        sb.Append(str);
        return sb.ToString();

    }
    static void Main()
    {
        List<string> words = new List<string>();
        string wordsFileName = @"..\..\words.txt";
        //Reads all the words from the file a adds them to a string list.
        try
        {
            StreamReader readWords = new StreamReader(wordsFileName);
            using (readWords)
            {
                string line = readWords.ReadLine();
                while (line != null)
                {
                    words.Add(GetWordsRegularExpressions(line));
                    line = readWords.ReadLine();
                }
            }
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.Message);
        }
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (writer)
        {
            string temp = string.Empty;
            string fileToRead = @"..\..\text.txt";
            try
            {
                StreamReader reader = new StreamReader(fileToRead);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        //Swap the words with ""
                        for (int i = 0; i < words.Count; i++)
                        {
                            temp = (Regex.Replace(line, words[i], ""));
                        }
                        // Move the period if one of the words was at the 
                        //end of the sentence --> some sample . -> some sample.
                        writer.WriteLine(Regex.Replace(line, " \\.", "."));
                        line = reader.ReadLine();
                    }
                }
            }
            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        //Replace files and deleting unnecessary files.
        File.Replace(@"..\..\test1.txt", @"..\..\text.txt", @"..\..\testbackup.txt");
        File.Delete(@"..\..\testbackup.txt");
        File.Delete(@"..\..\test1.txt");
    }
}
