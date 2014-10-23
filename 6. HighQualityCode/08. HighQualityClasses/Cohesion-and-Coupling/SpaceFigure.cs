namespace CohesionAndCoupling
{
    using System;

    public class SpaceFigure
    {
        private double width;
        private double height;
        private double depth;

        public SpaceFigure(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
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
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.width * this.height * this.depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = Math.Sqrt(
                this.width * this.width + this.height * this.height + this.depth * this.depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = Math.Sqrt(this.width * this.width + this.height * this.height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = Math.Sqrt(this.width * this.width + this.depth * this.depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = Math.Sqrt(this.height * this.height + this.depth * this.depth);
            return distance;
        }
    }
}
