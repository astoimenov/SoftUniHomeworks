/* Write an expression that calculates rectangle’s perimeter and area by given width and height. */

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * width + 2 * height;
        Console.WriteLine("Area: {0}", area);
        Console.WriteLine("Perimeter: {0}", perimeter);
    }
}