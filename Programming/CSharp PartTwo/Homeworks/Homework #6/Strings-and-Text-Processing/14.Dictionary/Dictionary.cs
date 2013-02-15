/*A dictionary is stored as a sequence of text lines 
 * containing words and their explanations. Write a 
 * program that enters a word and translates it by 
 * using the dictionary.
 */
using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> words = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        words.Add(".NET", "platform for applications from Microsoft");
        words.Add("CLR", "managed execution environment for .NET");
        words.Add("namespace", "hierarchical organization of classes");

        //string word = "CLR";
        string word = string.Empty;
        string description = string.Empty;
        while (!(words.ContainsKey(word)))
        {
            Console.Write("Enter a word: ");
            word = Console.ReadLine();
            if (words.ContainsKey(word))
            {
                Console.WriteLine(word + " - " + words[word]);
            }
            else
            {
                Console.Write("Enter a decription: ");
                description = Console.ReadLine();
                words.Add(word, description);
                Console.WriteLine("Word is added to dictionary!");
            }
 
        }
    }
}
