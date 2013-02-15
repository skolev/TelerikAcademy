using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        string enteredNumber = Console.ReadLine();
        uint number;
        bool parseSuccess = uint.TryParse(enteredNumber, out number);
        int p1 = 3;
        int p2 = 24;
        if (parseSuccess)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            uint result = (((number & ~(7u << p1)) & ~(7u << p2)) | (((number & (7u << p1)) >> p1) << p2)) | (((number & (7u << p2)) >> p2) << p1);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else Console.WriteLine("You entered invalid number.");
    }
}    
