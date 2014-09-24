namespace P03Paths
{
    using System;
    using System.Collections.Generic;
    using P01Point3D;

    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(params Point3D[] points)
        {
            if (points.Length > 0)
            {
                this.path.AddRange(points);
            }
        }

        public static void Main()
        {
        }

        public void AddPoint(Point3D p)
        {
            this.path.Add(p);
        }

        public override string ToString()
        {
            return string.Join(" ", this.path);
        }
    }
}
