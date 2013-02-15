using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        int decNumber = 0;

        // Multiply each numeral by its exponent
        for (int i = 0; i < binary.Length; i++)
        {
                decNumber += (int)Math.Pow(2, (binary.Length - i - 1));
        }
        Console.WriteLine(decNumber);
    }
}

