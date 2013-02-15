using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients of the equation ax^2+bx+c=0");
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        float c = float.Parse(Console.ReadLine());
        double x;
        double x1;
        double x2;
        double discriminant = (Math.Pow(b, 2) - 4 * a * c);


        if (a == 0)
        {
            Console.Write("The equation is linear. Has root: ");
            Console.WriteLine((-c) / b);
        }
        else if (discriminant == 0)
        {
            x = ((-b) / (2 * a));
            Console.Write("The equation has one root x1=x2=");
            Console.WriteLine(x);
        }
        else if (discriminant > 0)
        {
            x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The equation has roots x1= {0:F3}, x2={1:F3}", x1, x2);
        }
        else
        {
            Console.WriteLine("Equation has no real roots!");
        }
    }
}