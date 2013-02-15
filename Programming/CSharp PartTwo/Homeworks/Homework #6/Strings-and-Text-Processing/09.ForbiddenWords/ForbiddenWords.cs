/* We are given a string containing a list of forbidden 
 * words and a text containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks.
 */
using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        char[] separator = {',',' '};
        string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords = "PHP, CLR, Microsoft";
        string[] words = forbiddenWords.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            str = Regex.Replace(str, @"\b" + words[i] + @"\b", new string('*', words[i].Length));
        }
        Console.WriteLine(str);
    }
}
