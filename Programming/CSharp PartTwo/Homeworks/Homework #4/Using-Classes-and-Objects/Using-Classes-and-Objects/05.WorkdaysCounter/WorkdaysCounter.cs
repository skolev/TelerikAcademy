using System;

class WorkdaysCounter
{
    static void Main()
    {
        //Getting the entered date.
        Console.Write("Enter a date (DD.MM.YYYY): ");
        string str = Console.ReadLine();
        string[] enteredDay = str.Split('.');
        int day = int.Parse(enteredDay[0]);
        int month = int.Parse(enteredDay[1]);
        int year = int.Parse(enteredDay[2]);
        DateTime enteredDate = new DateTime(year, month, day);
        //Getting current date.
        DateTime startingDate = DateTime.Today;

        //Calc period in days.
        int period = (enteredDate - startingDate).Days;
        Console.WriteLine(period);
        int counter = 0;

        //Official holiday in 2013
        //info почивнидни.com
        DateTime[] officialHolidays = new[]
        {
            new DateTime(2013, 1, 1),
            new DateTime(2013, 3, 3),
            new DateTime(2013, 5, 1),
            new DateTime(2013, 5, 2),
            new DateTime(2013, 5, 3),
            new DateTime(2013, 5, 4),
            new DateTime(2013, 5, 5),
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 24),
            new DateTime(2013, 9, 6),
            new DateTime(2013, 9, 22),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31),
        };

        //Checking day by day if it is Saturday, Sunday or official holiday.
        for (int index = 0; index < period; index++)
        {
            startingDate = startingDate.AddDays(1);

            if ((startingDate.DayOfWeek == DayOfWeek.Saturday) ||
                (startingDate.DayOfWeek == DayOfWeek.Sunday))
            {
                continue;
            }
            foreach (var dayoff in officialHolidays)
            {
                if (startingDate == dayoff)
                {
                    counter--;
                }
            }
            counter++;
        }
        Console.WriteLine(counter);


    }
}
