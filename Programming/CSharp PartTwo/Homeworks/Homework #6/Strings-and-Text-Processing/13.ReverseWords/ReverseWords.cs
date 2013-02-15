//Write a program that reverses the words in given sentence.
using System;
using System.Text;

class ReverseWords
{
    static string Reverse(string[] str)
    {
        StringBuilder reversed = new StringBuilder();

        foreach (var ch in str)
        {
            reversed.Insert(0, ch);
        }
        return reversed.ToString();
    }
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string sentenceEnd = sentence.Substring(sentence.Length - 1, 1);
        sentence = sentence.Remove(sentence.Length - 1, 1);
        string[] sentenceWords = sentence.Split(' ');
        int comaIndex = 0;

        for (int i = 0; i < sentenceWords.Length; i++)
        {
            if (sentenceWords[i].IndexOf(',') != -1)
            {
                sentenceWords[i] = sentenceWords[i].Trim(',');
                comaIndex = i;
            }
        }
        for (int i = sentenceWords.Length - 1; i >= 0; i--)
        {
            if (i == (sentenceWords.Length - 1 - comaIndex))
            {
                Console.Write(sentenceWords[i] + ", ");
            }
            else if (i == 0)
            {
                Console.Write(sentenceWords[i] + sentenceEnd);
            }
            else
            {
                Console.Write(sentenceWords[i] + " ");
            }
        }


        Console.WriteLine();
    }
}
