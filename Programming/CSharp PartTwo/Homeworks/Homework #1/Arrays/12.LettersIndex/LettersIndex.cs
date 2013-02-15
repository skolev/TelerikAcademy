using System;

class LettersIndex
{
    static void Main()
    {
        //Creating an array containing all letters from the alphabet (a-z)
        int number = 97;
        char[] arr = new char[26];
        for (int index = 0; index < arr.Length; index++)
        {
            arr[index] = (char)number;
            number++;
        }
        Console.Write("Enter a word: ");
        string enteredWord = Console.ReadLine();
        enteredWord = enteredWord.ToLower();
        foreach (var letter in enteredWord)
        {
            for (int i = 0; i < arr.Length; i++)
            {   
                if (letter == arr[i])
                {
                    Console.WriteLine("Letter {0} index is: {1}",letter,i);
                }
            }
        }
    }
}    

