using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static List<byte> DecToBase(ulong number)
    {
        List<byte> numberToPrint = new List<byte>();
        do
        {
            numberToPrint.Add((byte)(number % 256));
            number /= 256;
        } while (number != 0);
        numberToPrint.Reverse();
        return numberToPrint;

    }
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<byte> kaspichanNumber = new List<byte>();
        if (number >= 256)
        {
            kaspichanNumber = DecToBase(number);
            foreach (var digit in kaspichanNumber)
            {
                if (digit < 26)
                {
                    Console.Write((char)(digit + 65));
                }
                else
                {
                    Console.Write((char)(digit / 26 + 96));
                    Console.Write((char)(digit % 26 + 65));
                }
            }
        }
        else if (number >= 26)
        {
            Console.Write((char)(number / 26 + 96));
            Console.Write((char)(number % 26 + 65));
        }
        else 
        {
            Console.Write((char)(number + 65));
        }
        Console.WriteLine();


    }
}