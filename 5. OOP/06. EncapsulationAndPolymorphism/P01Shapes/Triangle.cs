namespace P01Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private double angle;

        public Triangle(double width, double height, double angle)
            : base(width, height)
        {
            this.angle = angle;
        }

        public double Angle
        {
            get { return this.angle; }
            set { this.angle = value; }
        }

        public override double CalculateArea()
        {
            double area = (Math.Sin(this.angle * Math.PI / 180) * this.Width * this.Height) / 2.0;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double angleCos = Math.Cos(this.angle * Math.PI / 180);
            double thirdSide =
                Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) -
                          (2 * this.Height * this.Width * angleCos));
            double perimeter = this.Width + this.Height + thirdSide;
            return perimeter;
        }
    }
}
