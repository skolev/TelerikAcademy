//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
using System;

class StringToUnicode
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();

        foreach (var ch in arr)
        {
            Console.Write("\\u{0:x4}", (int)ch);
        }
        Console.WriteLine();
    }
}
