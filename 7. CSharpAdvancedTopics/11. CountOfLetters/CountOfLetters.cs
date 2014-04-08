/* Write a program that reads a list of letters and prints for each letter
 * how many times it appears in the list. The letters should be listed in
 * alphabetical order. Use the input and output format from the examples below. */

using System;
using System.Collections.Generic;
using System.Linq;

public class CountOfLetters
{
    public static void Main()
    {
        int count = 0;
        string input = Console.ReadLine();
        Console.WriteLine();

        string[] inputArray = input.Split(' ');
        List<string> lettersList = inputArray.ToList();

        lettersList.Sort();
        List<string> letters = new List<string>();
        foreach (string letter in lettersList.Where(letter => !letters.Contains(letter)))
        {
            letters.Add(letter);
        }

        foreach (string letter in letters)
        {
            count += lettersList.Count(s => letter == s);
            Console.WriteLine("{0} -> {1}", letter, count);
            count = 0;
        }
    }
}