namespace Estates.Data.Estates
{
    using System;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Apartment : Estate, IApartment
    {
        private int rooms;
        private bool hasElevator;

        public Apartment(
            string name = null, 
            EstateType type = EstateType.Apartment,
            double area = 0, 
            string location = null, 
            bool isFurnished = false, 
            int rooms = 0, 
            bool hasElevator = false) 
            : base(name, type, area, location, isFurnished)
        {
            this.rooms = rooms;
            this.hasElevator = hasElevator;
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rooms can't have negative value!", "Rooms");
                }

                this.rooms = value;
            }
        }

        public bool HasElevator
        {
            get { return this.hasElevator; }
            set { this.hasElevator = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(", Rooms: " + this.rooms);
            output.Append(", Elevator: " + (this.hasElevator ? "Yes" : "No"));
            return output.ToString();
        }
    }
}
