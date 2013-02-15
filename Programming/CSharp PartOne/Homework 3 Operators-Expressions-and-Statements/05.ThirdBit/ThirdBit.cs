using System;

class ThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int check = (mask & number) >> p;
        bool result = check == 1;
        Console.WriteLine((result) ? "Bit is 1" : "Bit is 0");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}    

