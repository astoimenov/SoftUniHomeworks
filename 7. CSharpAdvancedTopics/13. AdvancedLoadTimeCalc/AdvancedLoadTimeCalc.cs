﻿/* We have a report that holds dates, web site URLs and load times (in seconds)
 * in the same format like in the examples below. Your tasks is to calculate the
 * average load time for each URL. Print the URLs in the same order as they first 
 * appear in the input report. Print the output in the format given below. */

using System;
using System.Collections.Generic;
using System.Linq;

public static class AdvancedLoadTimeCalc
{
    public static void Main()
    {
        List<string> sites = new List<string>();
        List<double> times = new List<double>();
        string input = Console.ReadLine();
        while (input != string.Empty)
        {
            input = input.Substring(18);
            string[] divided = input.Split();
            sites.Add(divided[0]);
            times.Add(double.Parse(divided[1]));
            input = Console.ReadLine();
        }

        var dict = new Dictionary<string, double>();
        foreach (var site in sites)
        {
            if (!dict.ContainsKey(site))
            {
                dict.Add(site, 0);
            }
        }

        for (int j = 0; j < dict.Count; j++)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < sites.Count; i++)
            {
                if (sites[i] == dict.ElementAt(j).Key)
                {
                    count++;
                    sum += times[i];
                }
            }

            double average = sum / count;
            dict[dict.ElementAt(j).Key] = average;
        }

        foreach (var pair in dict)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}