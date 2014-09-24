namespace P02DistanceCalculator
{
    using System;
    using P01Point3D;

    public static class DistanceCalculator
    {
        public static double DistanceCalc(Point3D p1, Point3D p2)
        {
            double xDiff = p2.X - p1.X;
            double yDiff = p2.Y - p1.Y;
            double zDiff = p2.Z - p1.Z;
            double distance = Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
            return distance;
        }

        public static void Main()
        {
            Point3D p1 = new Point3D(-7, -4, 3);
            Point3D p2 = new Point3D(17, 6, 2.5);

            Console.WriteLine("d = " + DistanceCalc(p1, p2));
        }
    }
}
