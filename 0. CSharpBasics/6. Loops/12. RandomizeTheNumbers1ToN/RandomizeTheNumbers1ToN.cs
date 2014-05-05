/* Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. */

using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int tmp;
        int[] nums = new int[n];
        Random random = new Random();
        int randomIndex = random.Next(0, nums.Length);
        for (int i = 0; i <= n - 1; i++)
        {
            nums[i] = i + 1;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            tmp = nums[i];
            nums[i] = nums[randomIndex];
            nums[randomIndex] = tmp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
        Console.WriteLine();
    }
}