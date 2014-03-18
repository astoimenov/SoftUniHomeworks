/* Write a program that enters 5 numbers 
 * (given in a single line, separated by a space), calculates and prints their sum.  */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Numbers:");
        string[] tokens = Console.ReadLine().Split(' ');
        double sum = 0.0;
        double a;

        for (int i = 0; i < tokens.Length; i++)
        {
            a =+ double.Parse(tokens[i]);
            sum += a;
        }
        Console.WriteLine(sum);
    }
}