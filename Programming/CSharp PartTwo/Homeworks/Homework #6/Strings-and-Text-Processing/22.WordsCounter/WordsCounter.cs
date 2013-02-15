/*Write a program that reads a string 
 * from the console and lists all different 
 * words in the string along with information 
 * how many times each word is found.
 */

using System;
using System.Collections.Generic;

class WordsCounter
{
    static void Main()
    {
        char[] separators = new char[] { ',', '.', ' ' };
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //Test string
        string str = "our our our our our our This is our first line. This is our second line.";
        //Console.Write("Enter a string: ");
        //string str = Console.ReadLine();
        string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        for (int index = 0; index < words.Length; index++)
        {
            if (!dictionary.ContainsKey(words[index]))
            {
                dictionary.Add(words[index], 1);
            }
            else if (dictionary.ContainsKey(words[index]))
            {
                dictionary[words[index]]++;
            }   
        }
        foreach (KeyValuePair<string, int> pair in dictionary)
        {
            Console.WriteLine("{0} - {1}",
            pair.Key,
            pair.Value);
        }
    }
}
