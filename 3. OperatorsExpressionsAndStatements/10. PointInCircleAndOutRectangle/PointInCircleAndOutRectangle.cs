/* Write an expression that checks for given point (x, y)
 * if it is within the circle K({1, 1}, 1.5) and out of the 
 * rectangle R(top=1, left=-1, width=6, height=2).  */

using System;

class PointInCircleAndOutRectangle
{
    static void Main()
    {
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;

        bool isInCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(radius, 2);
        
        if (isInCircle && y - 1 > 1)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}