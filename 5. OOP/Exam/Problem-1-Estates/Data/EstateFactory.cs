namespace Estates.Data
{
    using System;
    using Estates;
    using Interfaces;
    using Offers;

    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new CustomEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    return new Apartment();
                case EstateType.Garage:
                    return new Garage();
                case EstateType.House:
                    return new House();
                case EstateType.Office:
                    return new Office();
                default:
                    throw new ArgumentException("Invalid type!", "type");
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Rent:
                    return new RentOffer();
                case OfferType.Sale:
                    return new SaleOffer();
                default:
                    throw new ArgumentException("Invalid type!", "type");
            }
        }
    }
}
