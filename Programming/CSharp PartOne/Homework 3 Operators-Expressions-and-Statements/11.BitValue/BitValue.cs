using System;

class BitValue
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit pisition (counting from 0): ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int bitValue = i & mask;
        bitValue = bitValue >> b;
        Console.WriteLine("Value: {0}", bitValue);
    }
}    

