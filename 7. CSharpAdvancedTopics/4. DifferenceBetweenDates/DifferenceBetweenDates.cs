/* Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. */

using System;
using System.Globalization;

public class DifferenceBetweenDates
{
    public static void Main()
    {
        Console.Write("First date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d", CultureInfo.CreateSpecificCulture("de-DE"));
        Console.Write("Second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d", CultureInfo.CreateSpecificCulture("de-DE"));

        int daysBetween = (int)(secondDate - firstDate).TotalDays;

        Console.WriteLine();
        Console.WriteLine(daysBetween);
    }
}