using System;

class SwapBits
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        string enteredNumber = Console.ReadLine();
        uint number;
        bool parseSuccess = uint.TryParse(enteredNumber, out number);
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        k--;
        int mask = 1 << k;
        int bits = 0;
        bits = bits | mask;
        for (int i = 0; i < k; i++)
        {
            mask = 1 << i;
            bits = bits | mask;
        }
        uint kBits = (uint)bits;
        if (parseSuccess)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            uint finalResult = (((number & ~(kBits << p)) & ~(kBits << q)) | (((number & (kBits << p)) >> p) << q)) | (((number & (kBits << q)) >> q) << p);
            Console.WriteLine(Convert.ToString(finalResult, 2).PadLeft(32, '0'));

        }
        else Console.WriteLine("You entered invalid number.");
    }
}    

