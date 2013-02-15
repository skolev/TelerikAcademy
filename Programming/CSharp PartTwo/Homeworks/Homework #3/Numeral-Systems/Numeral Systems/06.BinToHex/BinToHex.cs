using System;

class BinToHex
{
    static void BinToHexDigit(string hex)
    {
        int digitHex = 0;
        for (int i = 0; i < 4; i++)
        {
                digitHex += (int)Math.Pow(2, (3 - i));
        }
        if (digitHex > 9)
        {
            switch (digitHex)
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
            Console.Write(digitHex);
        }
    }
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        while (binary != string.Empty)
        {
            string hexDigit = binary.Substring(0, 4);
            BinToHexDigit(hexDigit);
            binary = binary.Remove(0, 4);
        }
        Console.WriteLine();

    }
}

