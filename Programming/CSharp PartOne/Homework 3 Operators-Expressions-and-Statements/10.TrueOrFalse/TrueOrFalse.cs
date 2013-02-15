using System;

class TrueOrFalse
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit pisition (counting from 0): ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result = v & mask;
        bool isTrue = (result >> p) == 1;
        Console.WriteLine(isTrue);
    }
}    

