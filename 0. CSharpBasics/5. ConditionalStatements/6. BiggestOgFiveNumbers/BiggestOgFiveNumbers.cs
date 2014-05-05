/* Write a program that finds the biggest of five numbers by using only five if statements. */

using System;

class BiggestOgFiveNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e: ");
        double e = double.Parse(Console.ReadLine());
        double biggestNum = 0.0;
        if (a > b && a > c && a > d && a > e)
        {
            biggestNum = a;
        }
        if (b > a && b > c && b > d && d > e)
        {
            biggestNum = b;
        }
        if (c > b && c > a && c > d && c > e)
        {
            biggestNum = c;
        }
        if (d > a && d > b && d > c && d > e)
        {
            biggestNum = d;
        }
        if (e > a && e > b && e > c && e > d)
        {
            biggestNum = e;
        }
        Console.WriteLine("The biggest is {0}", biggestNum);
    }
}