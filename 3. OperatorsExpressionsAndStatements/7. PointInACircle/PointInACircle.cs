/* Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). */

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;

        bool isInCircle = (x * x + y * y) <= radius;
        Console.WriteLine(isInCircle);
    }
}