/*Write a program that finds how many times a 
 * substring is contained in a given text (perform 
 * case insensitive search).
 */

using System;

class SubstringCounter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string enteredString = Console.ReadLine();
        Console.Write("Enter a substring: ");
        string countedSubstring = Console.ReadLine();
        int counter = 0;
        int index = 0;
        enteredString = enteredString.ToLower();
        while (enteredString.IndexOf(countedSubstring, index) != - 1)
        {
            counter++;
            index = enteredString.IndexOf(countedSubstring, index) + 1;
        }
        Console.WriteLine(counter);
    }
}
