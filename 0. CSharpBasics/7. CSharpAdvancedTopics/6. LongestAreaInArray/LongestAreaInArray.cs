/* Write a program to find the longest area of equal elements
 * in stringsArray of strings. You first should read an integer n and n
 * strings (each at a separate line), then find and print the longest 
 * sequence of equal elements (first its length, then its elements). 
 * If multiple sequences have the same maximal length, print the leftmost of them. */

using System;
using System.Collections.Generic;
using System.Linq;

public class LongestAreaInstringsArray
{
    public static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        string[] stringsArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            stringsArray[i] = Console.ReadLine();
        }

        int lenghtCount = 0,
            counter = 0,
            temp = 0,
            count = 0,
            len = 0;
        List<string> equal = new List<string>();

        for (int k = 0; k < stringsArray.Length; k++)
        {
            for (int j = 1 + k; j < stringsArray.Length; j++)
            {
                if (stringsArray[k] == stringsArray[j])
                {
                    if (stringsArray.Length == equal.Count + 1 && counter == 0)
                    {
                        temp++;
                        equal.Add(stringsArray[k]);
                        Console.WriteLine(temp);
                        foreach (var item in equal)
                        {
                            Console.WriteLine(item);
                        }

                        return;
                    }

                    if (temp == k && j == stringsArray.Length - 1)
                    {
                        equal.RemoveRange(0, count + 1);
                        Console.WriteLine(temp);
                        foreach (var item in equal)
                        {
                            Console.WriteLine(item);
                        }

                        return;
                    }

                    equal.Add(stringsArray[k]);
                    temp++;
                    lenghtCount++;
                    counter++;
                    len = count;
                    count = counter;
                }
                else if (temp > 0)
                {
                    equal.Add(stringsArray[k]);
                    temp = 0;
                    k = j;
                }
            }

            counter = 0;
        }

        if (lenghtCount == 0)
        {
            counter = 1;
            Console.WriteLine(counter);
            var lenghts = from element in stringsArray
                          orderby element.Length
                          select element;
            Console.WriteLine(lenghts.Last());
            return;
        }

        if (temp == equal.Count)
        {
            equal.Add(stringsArray[temp]);
            counter = equal.Count;
        }
        else if (len > temp)
        {
            equal.Reverse();
            equal.RemoveRange(0, temp);
            counter = equal.Count;
        }
        else if (temp > len)
        {
            equal.RemoveRange(0, len);
            counter = equal.Count;
        }
        else if (len == temp)
        {
            equal.Reverse();
            equal.RemoveRange(0, temp);
            counter = equal.Count;
        }

        Console.WriteLine(counter);
        foreach (var item in equal)
        {
            Console.WriteLine(item);
        }
    }
}