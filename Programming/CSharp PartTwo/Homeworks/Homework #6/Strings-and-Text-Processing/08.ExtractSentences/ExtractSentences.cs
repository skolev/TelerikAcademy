//Write a program that extracts from a given text all sentences containing given word.
using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = @"\bin\b";
        string[] sentences = str.Split('.');
        foreach (var sentence in sentences)
        {
            if (Regex.Matches(sentence, word).Count > 0)
            {
                Console.WriteLine(sentence.TrimStart() + ".");
            }
        }

    }
}
