namespace P01Point3D
{
    using System;

    public class Point3D
    {
        private static Point3D startingPoint;
        private double x;
        private double y;
        private double z;

        public Point3D()
        {
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint = new Point3D(0, 0, 0); }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static void Main()
        {
            Point3D p = new Point3D { X = 4, Y = 7, Z = 8 };
            Console.WriteLine(p.ToString());
            Console.WriteLine(StartingPoint);
        }

        public override string ToString()
        {
            return string.Format("Point3D {{ {0}, {1}, {2} }}", this.x, this.y, this.z);
        }
    }
}
