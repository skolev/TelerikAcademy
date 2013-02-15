using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an odd number: ");
        int NumberToCheck = int.Parse(Console.ReadLine());
        Console.WriteLine((NumberToCheck % 2 == 0) ? "Even" : "Odd");
    }
}    

