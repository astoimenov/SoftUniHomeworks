namespace Estates.Data.Estates
{
    using System;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class House : Estate, IHouse
    {
        private int floors;

        public House(
            string name = null, 
            double area = 0,
            string location = null,
            bool isFurnished = false,
            int floors = 0) 
            : base(name, EstateType.House, area, location, isFurnished)
        {
            this.floors = floors;
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of floors can't be negative!", "Floors");
                }

                this.floors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(", Floors: " + this.floors);
            return output.ToString();
        }
    }
}
