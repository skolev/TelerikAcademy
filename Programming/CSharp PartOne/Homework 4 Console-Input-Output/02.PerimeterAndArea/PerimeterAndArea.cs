using System;

class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius (in cm): ");
        string radius = Console.ReadLine();
        float circleRadius;
        bool parseSuccess = float.TryParse(radius, out circleRadius);
        if (parseSuccess && circleRadius > 0)
        {
            Console.WriteLine("Circle perimeter is {0:F3} cm , and area is {1:F3} cm^2", (2 * Math.PI * circleRadius),
                              (Math.PI * Math.Pow(circleRadius, 2)));
        }
        else 
        {
            Console.WriteLine("Invalid input!");
        }
    }
}    

