/*Write a program that extracts from given XML file all the text without the tags. 
 */
using System;
using System.IO;
using System.Text;

class ExtractLines
{
    //Getting a string from given position from '>' to '<'
    static string ExtractWord(string s, int firstIndex, int secondIndex)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = firstIndex + 1; i < secondIndex; i++)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
    static void Main()
    {
        string temp = string.Empty;
        string str = string.Empty;
        StreamReader reader = new StreamReader(@"..\..\xml.txt");
        using (reader)
        {
            str = reader.ReadToEnd();
        }
        int firstIndex = str.IndexOf('>');
        int secondIndex = str.IndexOf('<', 1);
        while (firstIndex != -1 && secondIndex != -1)
        {
            temp = (ExtractWord(str, firstIndex, secondIndex));
            if (temp.Length != 0)
            {
                //.Trim removes white spaces
                Console.WriteLine(temp.Trim(' '));
            }
            firstIndex = str.IndexOf('>', firstIndex + 1);
            secondIndex = str.IndexOf('<', secondIndex + 1);
        }
    }
}

