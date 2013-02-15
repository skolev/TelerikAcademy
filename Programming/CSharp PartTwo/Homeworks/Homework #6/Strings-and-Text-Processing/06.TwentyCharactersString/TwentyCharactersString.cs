/* Write a program that reads from the console a string 
 * of maximum 20 characters. If the length of the string 
 * is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.
 */

using System;
using System.Text;

class TwentyCharactersString
{
    static void Main()
    {

        string enteredString = string.Empty;
        do
        {
            Console.Write("Enter a string (max 20 characters): ");
            enteredString = Console.ReadLine();
        } while (enteredString.Length > 20);

        StringBuilder sb = new StringBuilder();
        sb.Append(enteredString);
        while (sb.Length < 20)
        {
            sb.Append('*');
        }
        Console.WriteLine(sb.ToString());
    }
}

