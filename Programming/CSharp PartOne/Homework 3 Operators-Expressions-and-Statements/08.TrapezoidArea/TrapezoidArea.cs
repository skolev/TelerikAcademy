using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid parameters");
        Console.Write("Enter side a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter side h: ");
        float h = float.Parse(Console.ReadLine());
        float trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid's area: {0:F2}", trapezoidArea);
    }
}    

