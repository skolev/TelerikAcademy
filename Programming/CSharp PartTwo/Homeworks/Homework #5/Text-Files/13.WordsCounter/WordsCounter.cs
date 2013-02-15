/*Write a program that reads a list of words from a file 
 * words.txt and finds how many times each of the 
 * words is contained in another file test.txt. The 
 * result should be written in the file result.txt and 
 * the words should be sorted by the number of their 
 * occurrences in descending order. Handle all possible 
 * exceptions in your methods.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

class WordsCounter
{
    static void Main()
    {
        try
        {
            string wordsFileName = @"..\..\words.txt";
            string[] words = File.ReadAllLines(wordsFileName);
            int[] wordCounter = new int[words.Length];
            string fileToRead = @"..\..\text.txt";

            StreamReader reader = new StreamReader(fileToRead);
            using (reader)
            {
                string regex = "\\b";
                string line = reader.ReadLine();
                while (line != null)
                {

                    for (int i = 0; i < words.Length; i++)
                    {
                        // adds string regex to the current string doesn't change
                        //Finds the number of matches for a given word in the string.
                        wordCounter[i] += Regex.Matches(line.ToLower(), regex + words[i] + regex).Count;
                    }
                    line = reader.ReadLine();
                }
            }
            //Sort the array.
            Array.Sort(wordCounter, words);
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(words[i] + " - " + wordCounter[i]);
                }
            }
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}
