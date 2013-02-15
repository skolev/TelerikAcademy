/*Describe the strings in C#. What is typical for the 
 * string data type? Describe the most important methods 
 * of the String class.
 */

using System;
using System.Text;

class ReverseString
{
    static string Reverse(string str)
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
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine(Reverse(inputString));

    }
}
