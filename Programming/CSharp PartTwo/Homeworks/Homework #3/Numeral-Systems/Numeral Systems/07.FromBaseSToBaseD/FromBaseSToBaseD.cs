using System;
using System.Collections.Generic;

class FromBaseSToBaseD
{
    //Convert entered number(s) to number(10)
    static int BaseSToDec(string num, int numberBase)
    {
        int decNumber = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] - '0' < 10)
            {
                decNumber += (num[i] - '0') * (int)Math.Pow(numberBase, (num.Length - i - 1));
            }
            else
            {
                decNumber += (num[i] - '7') * (int)Math.Pow(numberBase, (num.Length - i - 1));
            }
        }
        return decNumber;
    }
    //Convert number(10) to number(d)
    static void DecToBaseD(int number, int numberBase)
    {
        List<byte> convertedNumber = new List<byte>();
        do
        {
            convertedNumber.Add((byte)(number % numberBase));
            number /= numberBase;
        } while (number != 0);

        convertedNumber.Reverse();
        foreach (var digit in convertedNumber)
        {
            if (digit > 9)
            {
                Console.Write("{0}",(char)(digit + 55));
            }
            else
            {
                Console.Write(digit);
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        string enteredNumber = Console.ReadLine();
        Console.Write("Enter base s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter base d: ");
        int d = int.Parse(Console.ReadLine());
        DecToBaseD(BaseSToDec(enteredNumber, s), d);

    }
}

