/* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        if (n>=1&&n<=20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + n - 1; j++)
                {
                    Console.Write("{0}  ", j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}