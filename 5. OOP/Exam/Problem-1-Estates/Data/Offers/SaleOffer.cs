namespace Estates.Data.Offers
{
    using System;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class SaleOffer : Offer, ISaleOffer
    {
        private decimal price;

        public SaleOffer(IEstate estate = null, decimal price = 0M) 
            : base(OfferType.Sale, estate)
        {
            this.price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative!", "Price");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(string.Format(", Price = " + this.price));
            return output.ToString();
        }
    }
}
