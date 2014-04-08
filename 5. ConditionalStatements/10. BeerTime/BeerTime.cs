/* A beer time is after 1:00 PM and before 3:00 AM. Write a program
 * that enters a time in format “hh:mm tt” (an hour in range [01...12], 
 * a minute in range [00…59] and AM / PM designator) and prints “beer time” 
 * or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed.  */

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        DateTime time;
        DateTime start = DateTime.Parse("01:00 PM");
        DateTime end = DateTime.Parse("03:00 AM");
        Console.Write("Time: ");
        string timeStr = Console.ReadLine();
        if (DateTime.TryParseExact(timeStr, "hh:mm tt", new CultureInfo("en-US"), DateTimeStyles.None, out time))
        {
            if (time >= start || time <= end)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}