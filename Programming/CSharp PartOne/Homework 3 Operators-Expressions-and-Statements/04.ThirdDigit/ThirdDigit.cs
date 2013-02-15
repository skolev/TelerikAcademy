using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter 3 digit number at least: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        numberToCheck = (numberToCheck / 100);
        Console.WriteLine(((numberToCheck % 10) == 7) ? "Third number is 7." : "Third number isn't 7.");
    }
}    

