/* Write a program that calculates the perimeter and the area of 
 * given polygon (not necessarily convex) consisting of n floating-point
 * coordinates in the 2D plane. Print the result rounded to two decimal
 * digits after the decimal point. Use the input and output format from
 * the examples. To hold the points, define a class Point(x, y). To hold 
 * the polygon use a Polygon class which holds a list of points. */

using System;

public static class PerimeterAndAreaOfPolygon
{
    public static void Main()
    {
        int pointsNumber = int.Parse(Console.ReadLine());
        int[,] matrix = new int[pointsNumber, 2];
        Point[] perimeter = new Point[pointsNumber];
        for (int i = 0; i < pointsNumber; i++)
        {
            string pointsCoordinates = Console.ReadLine();
            string[] coordinate = pointsCoordinates.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            perimeter[i] = new Point { X = int.Parse(coordinate[0]), Y = int.Parse(coordinate[1]) };
            matrix[i, 0] = int.Parse(coordinate[0]);
            matrix[i, 1] = int.Parse(coordinate[1]);
        }

        Console.WriteLine("perimeter = {0:F2}", CalcPerimeter(perimeter));
        Console.WriteLine("area = {0:F2}", CalcArea(matrix, pointsNumber));
    }

    private static double CalcDistance(int x1, int y1, int x2, int y2)
    {
        int distanceX = x2 - x1;
        int distanceY = y2 - y1;
        double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
        return distance;
    }

    private static double CalcPerimeter(Point[] points)
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += CalcDistance(
                points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
        }

        return perimeter;
    }

    private static double CalcArea(int[,] matrix, int rows)
    {
        double leftSideSum = 0;
        double rightSideSum = 0;
        for (int i = 0; i < rows - 1; i++)
        {
            leftSideSum += matrix[i, 0] * matrix[i + 1, 1];
            rightSideSum += matrix[i, 1] * matrix[i + 1, 0];
        }

        double matrixResult = Math.Abs((leftSideSum - rightSideSum) / 2);
        return matrixResult;
    }

    private class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}