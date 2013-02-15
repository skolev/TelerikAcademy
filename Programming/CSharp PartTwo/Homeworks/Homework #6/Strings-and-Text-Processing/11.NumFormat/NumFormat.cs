/* Write a program that converts a string 
 * to a sequence of C# Unicode character
 * literals. Use format strings. 
 */
using System;

class NumFormat
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal: {0,15}", num);

        Console.WriteLine("Hexadecimal: {0,15:x}", num);

        Console.WriteLine("Percentage {0,15:p}", num);

        Console.WriteLine("Scientific notation: {0,15:e}", num);

    }
}
