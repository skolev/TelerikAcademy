using System;
using System.Collections.Generic;

class HexToBin
{
    static void HexDigitToBin(int number)
    {
        List<byte> binary = new List<byte>();
        do
        {
            binary.Add((byte)(number % 2));
            number /= 2;
        } while (number != 0);

        binary.Reverse();
        foreach (var digit in binary)
        {
            Console.Write(digit);
        }
        Console.Write(" ");
    }
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();
        hex = hex.ToUpper();
        int digitToConvert = 0;
        for (int index = 0; index < hex.Length; index++)
        {
            switch (hex[index])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                    digitToConvert = hex[index] - '7';
                    break;
                default:
                    digitToConvert = hex[index] - '0';
                    break;
            }
            HexDigitToBin(digitToConvert);
        }
        Console.WriteLine();
    }
}    

