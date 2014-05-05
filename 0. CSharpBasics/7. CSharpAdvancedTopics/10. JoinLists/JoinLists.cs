/* Write a program that takes as input two lists of integers and joins them.
 * The result should hold all numbers from the first list, and all numbers from 
 * the second list, without repeating numbers, and arranged in increasing order.
 * The input and output lists are given as integers, separated by a space, each
 * list at a separate line. */

using System;
using System.Collections.Generic;
using System.Linq;

public class JoinLists
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        Console.WriteLine();

        string[] firstArray = first.Split(' ');
        string[] secondArray = second.Split(' ');

        List<int> firstList = firstArray.Select(int.Parse).ToList();
        List<int> secondList = secondArray.Select(int.Parse).ToList();

        foreach (int number in firstList)
        {
            if (!secondList.Contains(number))
            {
                secondList.Add(number);
            }
        }

        secondList.Sort();

        foreach (int number in secondList)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
    }
}