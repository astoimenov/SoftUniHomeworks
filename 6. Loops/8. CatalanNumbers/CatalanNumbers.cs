/* Write a program to calculate the nth Catalan number by given n (1 < n < 100). */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n;
        BigInteger nFact = 1,
                   nPlusFact = 1;
        do
        {
            Console.Write("n (1 < n < 100): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1 || n >= 100);

        for (int i = 1, j = (n + 1); i <= n; i++, j++)
        {
            nFact *= i;
            nPlusFact *= j;
        }

        BigInteger result = nPlusFact * nFact / (((n + 1) * nFact) * nFact);
        Console.WriteLine(result);
    }
}