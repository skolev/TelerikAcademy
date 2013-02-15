using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Greater number: {0}", Math.Max(a, b));
    }
}    

