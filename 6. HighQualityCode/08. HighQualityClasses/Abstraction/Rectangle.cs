namespace Abstraction
{
    using System;

    public class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width should be positive!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height should be positive!");
                }

                this.height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.width * this.Height;
            return surface;
        }
    }
}
