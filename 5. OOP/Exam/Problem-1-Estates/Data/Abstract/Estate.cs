namespace Estates.Data.Abstract
{
    using System;
    using System.Text;
    using Interfaces;

    public class Estate : IEstate
    {
        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;

        protected Estate(
            string name, EstateType type, double area, string location, bool isFurnished)
        {
            this.name = name;
            this.type = type;
            this.area = area;
            this.location = location;
            this.isFurnished = isFurnished;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name can't be empty!");
                }

                this.name = value;
            }
        }

        public EstateType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double Area
        {
            get
            {
                return this.area;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Area can't be negative!", "Area");
                }

                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location", "Location can't be empty!");
                }

                this.location = value;
            }
        }

        public bool IsFurnished
        {
            get { return this.isFurnished; }
            set { this.isFurnished = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.GetType().Name + ": ");
            output.Append("Name = " + this.name);
            output.Append(", Area = " + this.area);
            output.Append(", Location = " + this.location);
            output.Append(", Furnitured = " + (this.isFurnished ? "Yes" : "No"));
            return output.ToString();
        }
    }
}
