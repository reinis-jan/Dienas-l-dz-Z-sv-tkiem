﻿using System;

class Program
{
    static void Main()
    {
        // Šodienas datums
        DateTime today = DateTime.Today;

        // Aprēķins nākamajiem ziemīšiem
        DateTime nextChristmas = new DateTime(today.Year, 12, 25);

        // Ja šodiena ir vēlāks datums par Ziemassvētkiem, tad pieskaita lai ir pareizi.
        if (today > nextChristmas)
        {
            nextChristmas = new DateTime(today.Year + 1, 12, 25);
        }

        // Aprēķins cik dienas vajag līdz Z-svētkiem
        TimeSpan daysUntilChristmas = nextChristmas - today;

        // Output the result
        Console.WriteLine($"Palikušas {daysUntilChristmas.Days} dienas līdz Ziemassvētkiem.");
    }
}