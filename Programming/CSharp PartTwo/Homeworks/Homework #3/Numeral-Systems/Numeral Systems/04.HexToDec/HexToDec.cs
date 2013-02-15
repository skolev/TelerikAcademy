using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hex = Console.ReadLine();
        hex = hex.ToUpper();
        int decNumber = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                    decNumber += ((hex[i] - '7') * ((int)Math.Pow(16, (hex.Length - i - 1))));
                    break;
                default:
                    decNumber += ((hex[i] - '0') * ((int)Math.Pow(16, (hex.Length - i - 1))));
                    break;
            }
        }
        Console.WriteLine(decNumber);
    }
}

