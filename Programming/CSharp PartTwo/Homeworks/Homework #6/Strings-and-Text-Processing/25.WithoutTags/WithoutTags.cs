using System;
using System.Text;

class WithoutTags
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
        string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
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
