/* Write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.  */

using System;
using System.Numerics;

class CombinatoricsEquation
{
    static void Main()
    {
        int n, k;
        do
        {
            Console.Write("k (1 < k): ");
            k = int.Parse(Console.ReadLine());
            Console.Write("n (k < n < 100): ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
        } while (k <= 1 || n <= k || n >= 100);

        int sub = n - k;
        BigInteger sFact = 1,
                kFact = 1,
                nFact = 1;

        for (int i = 1; i <= sub; i++)
        {
            sFact *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                nFact *= i;
                kFact *= i;
            }
            else
            {
                nFact *= i;
            }
        }
        BigInteger result = nFact / (kFact * sFact);
        Console.WriteLine(result);
    }
}