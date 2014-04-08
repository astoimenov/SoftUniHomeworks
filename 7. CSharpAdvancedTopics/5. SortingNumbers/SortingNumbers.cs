/* Write a program that reads a number n and a sequence of n integers, sorts them and prints them. */

using System;

public class SortingNumbers
{
    public static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Array.Sort(nums);
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}