/* Write a program that calculates n! / k! for given n and k (1 < k < n < 100). */

using System;

class FactorialsDivision
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

        decimal nFact = 1, kFact = 1;

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
        decimal result = nFact / kFact;
        Console.WriteLine(result);
    }
}