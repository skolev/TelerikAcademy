/*Write a program that reads a string from the 
 * console and prints all different letters in the 
 * string along with information how many times 
 * each letter is found.
 */

using System;

class LetterCounter
{
    static void Main()
    {
        int[] letters = new int[123];
        //string str ="Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        string formattedStr = str.ToLower();
        char[] inputedString = formattedStr.ToCharArray();

        for (int index = 0; index < inputedString.Length; index++)
        {
            letters[inputedString[index]]++;
        }
        for (int i = 97; i < letters.Length; i++)
        {
            if (letters[i] != 0)
            {
                Console.WriteLine("{0} - {1} ",(char)i, letters[i]);
            }
        }
    }
}
