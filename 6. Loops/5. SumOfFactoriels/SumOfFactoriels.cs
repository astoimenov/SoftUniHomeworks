/* Write a program that, for a given two integer numbers n and x,
 * calculates the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n.  */

using System;

class SumOfFactoriels
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal exp = 1;
        decimal fact = 1;

        for (int i = 1; i <= n; i++)
        {
            exp *= x;
            fact *= i;
            sum += (fact / exp);
        }
        Console.WriteLine("Sum = {0:##.#####}", sum);
    }
}