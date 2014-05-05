/* Write a program that reads from the console a sequence of n 
 * integer numbers and returns the minimal, the maximal number
 * the sum and the average of all numbers (displayed with 2 digits
 * after the decimal point). The input starts by the number n 
 * (alone in a line) followed by n lines, each holding an integer number.  */

using System;

class MinMaxSumAvgOfNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] nums = new double[n];
        double min = 0, max = 0, sum = 0;
        for (int i = 0; i < n; i++)
        {
            nums[i] = double.Parse(Console.ReadLine());
        }
        foreach (var num in nums)
        {
            min = nums[0];
            max = nums[0];
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
            sum = sum + num;
        }
        double avg = sum / n;
        Console.WriteLine();
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:##.##}", avg);
    }
}