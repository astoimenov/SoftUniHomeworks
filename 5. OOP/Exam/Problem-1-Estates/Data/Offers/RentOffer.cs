namespace Estates.Data.Offers
{
    using System;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class RentOffer : Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public RentOffer(IEstate estate = null, decimal pricePerMonth = 0M) 
            : base(OfferType.Rent, estate)
        {
            this.pricePerMonth = pricePerMonth;
        }

        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative!", "PricePerMonth");
                }

                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format(", Price = " + this.pricePerMonth));
            return output.ToString();
        }
    }
}
