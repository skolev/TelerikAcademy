using System;

class ChangeValue
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit pisition (counting from 0): ");
        int p = int.Parse(Console.ReadLine());
        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
        }


        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}    

