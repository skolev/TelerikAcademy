using System;

class PointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter number coordinates");
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= 25) && ((x < -1) || (x > 5) || ((y > 1) || (y < -1)))) ?
                            "The point is within the circle and out of the rectangle at the same time." :
                            "The point isn't within the circle and out of the rectangle at the same time.");
    }
}    

