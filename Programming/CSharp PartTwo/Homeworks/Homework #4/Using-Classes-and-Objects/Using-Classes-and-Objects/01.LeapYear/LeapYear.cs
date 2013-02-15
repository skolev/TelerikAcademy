using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        short year = short.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year)? "Leap year.": "Non-leap year.");
    }
} 
