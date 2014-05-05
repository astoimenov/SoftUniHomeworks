/* Write a program to find the longest word in a text. */

using System;

public static class LongestWordInText
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim('.');
        string[] words = input.Split(' ');
        string longest = words[0];

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine();
        Console.WriteLine(longest);
    }
}