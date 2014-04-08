/* Write a program that finds the biggest of three numbers.  */

using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        double biggestNum = 0.0;
        if (a > b && a > c)
        {
            biggestNum = a;
        }
        else if (b > a && b > c)
        {
            biggestNum = b;
        }
        else if (c > b && c > a)
        {
            biggestNum = c;
        }
        Console.WriteLine("The biggest is {0}", biggestNum);
    }
}