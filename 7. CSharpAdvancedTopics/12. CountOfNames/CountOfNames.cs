/* Write a program that reads a list of names and prints for each
 * name how many times it appears in the list. The names should be
 * listed in alphabetical order. */

using System;
using System.Collections.Generic;
using System.Linq;

public static class CountOfNames
{
    public static void Main()
    {
        int count = 0;
        string input = Console.ReadLine();
        Console.WriteLine();

        string[] inputArray = input.Split(' ');
        List<string> namesList = inputArray.ToList();

        namesList.Sort();
        List<string> names = new List<string>();
        foreach (string name in namesList.Where(name => !names.Contains(name)))
        {
            names.Add(name);
        }

        foreach (string name in names)
        {
            count += namesList.Count(s => name == s);
            Console.WriteLine("{0} -> {1}", name, count);
            count = 0;
        }
    }
}