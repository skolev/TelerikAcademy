/*Write a program that reads a date and time given 
 * in the format: day.month.year hour:minute:second
 * and prints the date and time after 6 hours and 30 minutes 
 * (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class TimeAfter
{
    static void Main()
    {
        char[] separators = new char[] { '.', ':', ' ' };
        Console.Write("Enter date and time: ");
        string enteredDate = Console.ReadLine();
        //string[] dateOne = date.Split(separators);
        //int day = int.Parse(dateOne[0]);
        //int month = int.Parse(dateOne[1]);
        //int year = int.Parse(dateOne[2]);
        DateTime date = DateTime.Parse(enteredDate);
        date = date.AddHours(6.5);
        System.Threading.Thread.CurrentThread.CurrentCulture =
    new CultureInfo("bg-BG");
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss (dddd)"));
        Console.WriteLine();
    }
}
