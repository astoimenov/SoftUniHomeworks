namespace Estates.Data.Estates
{
    using Interfaces;

    public class Office : Apartment, IOffice
    {
        public Office(
            string name = null, 
            EstateType type = EstateType.Office, 
            double area = 0, 
            string location = null, 
            bool isFurnished = false, 
            int rooms = 0, 
            bool hasElevator = false) 
            : base(name, type, area, location, isFurnished, rooms, hasElevator)
        {
        }
    }
}
