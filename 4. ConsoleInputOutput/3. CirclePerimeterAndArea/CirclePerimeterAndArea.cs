/* Write a program that reads the radius r of a circle
 * and prints its perimeter and area formatted
 * with 2 digits after the decimal point. */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r: ");
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(r, 2);
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine();
        Console.WriteLine("Area: {0:##.00}", area);
        Console.WriteLine("Perimeter: {0:##.00}", perimeter);
    }
}