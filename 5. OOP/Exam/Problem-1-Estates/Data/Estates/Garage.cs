namespace Estates.Data.Estates
{
    using System;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Garage : Estate, IGarage
    {
        private int width;
        private int height;

        public Garage(
            string name = null, 
            double area = 0, 
            string location = null, 
            bool isFurnished = false, 
            int width = 0, 
            int height = 0)
            : base(name, EstateType.Garage, area, location, isFurnished)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width can't be negative!", "Width");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height can't be negative!", "Height");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format(", Width: {0}, Height: {1}", this.width, this.height));
            return output.ToString();
        }
    }
}
