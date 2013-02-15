using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<byte> binary = new List<byte>();
        // Divide by 16 and append the reminders
        do
        {
            binary.Add((byte)(number % 16));            
            number /= 16;
        } while (number!=0);
        // Reverse order
        binary.Reverse();
        foreach (var digit in binary)
        {
            //If digit is > 9 prints matching letter.
            if (digit > 9)
            {
                switch (digit)
                {
                    case 10: Console.Write('A'); break;
                    case 11: Console.Write('B'); break;
                    case 12: Console.Write('C'); break;
                    case 13: Console.Write('D'); break;
                    case 14: Console.Write('E'); break;
                    case 15: Console.Write('F'); break;
                }
            }
            else
            {
                Console.Write(digit);
            }
        }
        Console.WriteLine();
    }
}

