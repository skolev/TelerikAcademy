using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<byte> binary = new List<byte>();

        //Adds each bit in a list
        do
        {
            binary.Add((byte)(number % 2));            
            number /= 2;
        } while (number!=0);

        //Reverse the list
        binary.Reverse();
        foreach (var digit in binary)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}

