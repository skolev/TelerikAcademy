/*You are given a text. Write a program that changes 
 *the text in all regions surrounded by the tags
 *<upcase> and </upcase> to uppercase. The tags
 *cannot be nested.
 */
using System;
using System.Text.RegularExpressions;

class ChangeText
{
    static void Main()
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        string upperCase = string.Empty;
        int index = 0;

        while (str.IndexOf(startTag)!= -1)
        {   
            upperCase = str.Substring(str.IndexOf(startTag) + 8, str.IndexOf(endTag) - 8 - str.IndexOf(startTag)) ;
            str = Regex.Replace(str, str.Substring(str.IndexOf(startTag), str.IndexOf(endTag) + 9 - str.IndexOf(startTag)), upperCase.ToUpper());
        }
        Console.WriteLine(str);

    }
}
