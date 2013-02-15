using System;

class TriangleSurface
{
    //Calculate by the formula S = a*h(a)/2
    static double CalculateBySideAndAltitude()
    {
        Console.Write("Enter a side: ");
        float side = int.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        float altitude = float.Parse(Console.ReadLine());
        double result = (side * altitude) / 2.0;
        return result;
    }
    //Calculate by formula formula S = sqrt(p*(p-a)*(p-b)*(p-c))
    static double CalculateByThreeSides()
    {
        Console.Write("Enter first side: ");
        float firstSide = int.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        float secondSide = int.Parse(Console.ReadLine());
        Console.Write("Enter third side: ");
        float thirdSide = int.Parse(Console.ReadLine());
        double p = (firstSide + secondSide + thirdSide) / 2.0;
        double result = Math.Sqrt((p * (p - firstSide) * (p - secondSide) * (p - thirdSide)));
        return result;
    }
    //Calculte by formula S = (a*b*sin(gamma))/2
    static double CalculateByAngleAndTwoSides()
    {
        Console.Write("Enter first side: ");
        float firstSide = int.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        float secondSide = int.Parse(Console.ReadLine());
        Console.Write("Enter angle side (in deg): ");
        float degrees = int.Parse(Console.ReadLine());
        double angle = Math.PI * degrees / 180.0;
        double sinAngle = Math.Sin(angle);
        double result = (firstSide * secondSide * sinAngle) / 2.0;
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Calculate surface of a triangle by given:");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them.");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());
        double result = 0d;
        switch (choice)
        {
            case 1: result = CalculateBySideAndAltitude();
                break;
            case 2: result = CalculateByThreeSides();
                break;
            case 3: result = CalculateByAngleAndTwoSides();
                break;

        }
        Console.WriteLine("{0:F4}", result);
    }
}
