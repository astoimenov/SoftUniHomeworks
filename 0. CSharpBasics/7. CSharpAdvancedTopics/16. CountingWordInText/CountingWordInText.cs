/* Write a program that counts how many times a given word occurs in given text.
 * The first line in the input holds the word. The second line of the input holds
 * the text. The output should be a single integer number – the number of word
 * occurrences. Matching should be case-insensitive. Note that not all matching
 * substrings are words and should be counted. A word is a sequence of letters
 * separated by punctuation or start / end of text.  */

using System;
using System.Linq;

public static class CountingWordInText
{
    public static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] allWords = text.Split(
            new[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int count = allWords.Count(t => string.Equals(t, word, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(count);
    }
}