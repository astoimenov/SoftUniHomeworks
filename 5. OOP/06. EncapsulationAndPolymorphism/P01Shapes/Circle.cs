namespace P01Shapes
{
    using System;

    public class Circle : BasicShape
    {
        public Circle(double width) : base(width, width)
        {
        }

        public override double CalculateArea()
        {
            double area = Math.PI * this.Width * this.Width / 4;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = Math.PI * 2 * this.Width / 2;
            return perimeter;
        }
    }
}
