/* Write an expression that calculates trapezoid's area by given sides a and b and height h. */

using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h: ");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * (h / 2);

        Console.WriteLine("Area: {0}", area);
    }
}