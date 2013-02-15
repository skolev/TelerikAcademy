/*Write a program that reads two dates in the 
 *format: day.month.year and calculates the 
 *number of days between them.
 */
using System;

class DaysBetween
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string date = Console.ReadLine();
        string[] dateOne = date.Split('.');
        int day = int.Parse(dateOne[0]);
        int month = int.Parse(dateOne[1]);
        int year = int.Parse(dateOne[2]);
        DateTime firstDate = new DateTime(year, month, day);
        Console.Write("Enter the second date: ");
        date = Console.ReadLine();
        string[] dateTwo = date.Split('.');
        day = int.Parse(dateTwo[0]);
        month = int.Parse(dateTwo[1]);
        year = int.Parse(dateTwo[2]);
        DateTime secondDate = new DateTime(year, month, day);
        int result = (secondDate - firstDate).Days;
        if (result < 0)
        {
            result *= -1;
        }
        Console.WriteLine("Distance: " + result + " days");

    }
}
