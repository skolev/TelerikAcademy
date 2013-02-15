//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;

class Palindromes
{
    static void Main()
    {
        char[] separators = new char[] {'.',',',' '};
        string str = "Write a program civic that extracts from a given level text all  stats palindromes, e.g. ABBA, lamal, exe.";
        string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        bool palindrome = false;

        foreach (var word in words)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    palindrome = true;
                }
                else
                {
                    palindrome = false;
                }
            }
            if (palindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
