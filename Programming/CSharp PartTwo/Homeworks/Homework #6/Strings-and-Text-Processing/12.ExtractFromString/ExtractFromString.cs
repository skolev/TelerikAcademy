/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource] and extracts from it the 
 * [protocol], [server] and [resource] elements
 */
using System;

class ExtractFromString
{
    static void Main()
    {
        string str = @"http://www.devbg.org/forum/index.php";
        string[] s = { "[protocol]", "[server]", "[resource]" };
        int serverIndex = str.IndexOf(":") + 3;
        Console.WriteLine("{0} = \"{1}\"",s[0], str.Substring(0, str.IndexOf(":")));
        Console.WriteLine("{0} = \"{1}\"", s[1], str.Substring(serverIndex, str.IndexOf("/", serverIndex) - serverIndex));
        Console.WriteLine("{0} = \"{1}\"", s[1], str.Substring(str.IndexOf("/", serverIndex), str.Length - str.IndexOf("/", serverIndex)));


    }
}
