/*Write a program that reads a string from the 
 * console and replaces all series of consecutive 
 * identical letters with a single one.
 */
using System;
using System.Text;

class ConsecutiveLetters
{
    static string RemoveDuplica(string str)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(str[0]);
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1])
            {
                sb.Append(str[i]);
            }
        }
        return sb.ToString();
    }
    static void Main()
    {
        //Test string
        //string str = "aaaaabbbbbcdddeeeedssaa";
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.WriteLine(RemoveDuplica(str));

    }
}
