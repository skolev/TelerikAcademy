using System;

class PointCircle
{
    static void Main()
    {
        Console.WriteLine("Enter number coordinates");
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine((Math.Pow(x, 2) + Math.Pow(y, 2) <= 25)? "The point is within the circle." :
                                                                   "The point isn't within the circle.");
    }
}    

