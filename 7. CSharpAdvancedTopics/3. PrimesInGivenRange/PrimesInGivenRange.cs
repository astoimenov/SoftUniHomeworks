/* Write a method that calculates all prime numbers in given range and returns them as list of integers */

using System;
using System.Collections.Generic;
using System.Text;

public class PrimesInGivenRange
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        List<int> primes = FindPrimesInRange(start, end);

        foreach (var prime in primes)
        {
            output.AppendFormat("{0}, ", prime);
        }

        output.Remove(output.Length - 2, 2);
        Console.WriteLine(output);
    }

    private static bool IsPrime(int n)
    {
        int count = 0;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        if (count == 0 && n != 1 && n != 0)
        {
            return true;
        }

        return false;
    }

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}