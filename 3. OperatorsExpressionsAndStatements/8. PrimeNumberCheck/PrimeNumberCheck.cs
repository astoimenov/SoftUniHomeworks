/* Write an expression that checks if given positive integer
 * number n (n ≤ 100) is prime (i.e. it is divisible without
 * remainder only to itself and 1).  */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
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
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}