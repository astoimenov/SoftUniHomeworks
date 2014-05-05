/* Write a program that enters a number n and 
 * after that enters more n numbers and calculates and prints their sum.  */

using System;

class SumOfnNumber
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0, a;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine("sum = {0}", sum);
    }
}