﻿using System.Globalization;

internal class Program
{
    static void Main()

    {

        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        for (DateTime date = startDate; date <= endDate; date=date.AddDays(1))

        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||

            date.DayOfWeek == DayOfWeek.Sunday) { holidaysCount++; };
        }

        Console.WriteLine(holidaysCount);

    }
}

