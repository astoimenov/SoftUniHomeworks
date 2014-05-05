/* Write a program that takes as input two lists of names and removes from the first
 * list all names given in the second list. The input and output lists are given as words,
 * separated by a space, each list at a separate line.  */

using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNames
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        Console.WriteLine();

        string[] firstArray = first.Split(' ');
        string[] secondArray = second.Split(' ');

        List<string> firstList = firstArray.ToList();
        List<string> secondList = secondArray.ToList();

        for (int i = 0; i < firstList.Count; i++)
        {
            if (secondList.Contains(firstList.ElementAt(i)))
            {
                firstList.Remove(firstList.ElementAt(i));
                i--;
            }
        }

        foreach (string name in firstList)
        {
            Console.Write("{0} ", name);
        }

        Console.WriteLine();
    }
}