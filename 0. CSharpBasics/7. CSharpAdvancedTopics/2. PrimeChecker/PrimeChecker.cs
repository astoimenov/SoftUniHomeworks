/* Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. */

using System;

public class PrimeChecker
{
    public static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
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

        if (count == 0 && n != 1)
        {
            return true;
        }

        return false;
    }
}