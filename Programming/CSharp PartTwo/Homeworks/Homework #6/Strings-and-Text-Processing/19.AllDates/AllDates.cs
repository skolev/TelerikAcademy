/*Write a program that extracts from a given text all 
 * dates that match the format DD.MM.YYYY. Display 
 * them in the standard date format for Canada.
 */

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class AllDates
{
    static void Main()
    {
        string str = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        string dateFormat = @"\d{1,2}\.\d{1,2}\.\d{4}";
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        foreach (var date in Regex.Matches(str, dateFormat))
        {
            DateTime day = DateTime.Parse(date.ToString());

            Console.WriteLine(day.ToString("d.M.yyyy"));
        }
    }
}
