using System;

class DayOfTheWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today.ToString("dddd"));
    }
}

