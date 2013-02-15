using System;
using System.Text;

class TypeShortBinRep
{
    static string BinaryString(short number, short sign)
    {
        StringBuilder bin = new StringBuilder();
        for (int i = 15; i > 0; i--)
        {
            bin.Insert(0, (sign ^ (number % 2)));
            number /= 2;
        }
        bin.Insert(0, sign);
        return bin.ToString();

    }
    static void Main()
    {
        Console.Write("Enter a number [-32768, 32767]: ");
        short number = short.Parse(Console.ReadLine());
        short numSign = 0;
        if (number < 0)
        {
            numSign++;
            number = (short)(Math.Abs(number) - 1);
        }
        Console.WriteLine(BinaryString(number,numSign));
    }
}    
