using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter rectangle's height: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's width: ");
        int width = int.Parse(Console.ReadLine());
        int area = height * width;
        Console.WriteLine("Rectangle area is: {0}", area);
    }
}    

