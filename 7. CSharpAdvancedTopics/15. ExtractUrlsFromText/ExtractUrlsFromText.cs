using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class ExtractUrlsFromText
{
    public static void Main()
    {
        string input = Console.ReadLine();
        IEnumerable<string> urls = ExtractUrls(input);
        Console.WriteLine();
        foreach (string url in urls)
        {
            Console.WriteLine(url);
        }
    }

    private static IEnumerable<string> ExtractUrls(string str)
    {
        const string regexPattern = @"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*";
        MatchCollection matches = Regex.Matches(str, regexPattern, RegexOptions.IgnoreCase);

        return (from Match match in matches select match.ToString()).ToList();
    }
}