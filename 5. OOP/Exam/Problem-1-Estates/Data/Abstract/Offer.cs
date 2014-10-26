namespace Estates.Data.Abstract
{
    using System;
    using System.Text;
    using Interfaces;

    public abstract class Offer : IOffer
    {
        private OfferType type;
        private IEstate estate;

        protected Offer(OfferType type, IEstate estate)
        {
            this.type = type;
            this.estate = estate;
        }

        public OfferType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public IEstate Estate
        {
            get
            {
                return this.estate;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Estate", "Estate can't be null!");
                }

                this.estate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.type + ": ");
            output.Append("Estate = " + this.estate.Name);
            output.Append(", Location = " + this.estate.Location);
            return output.ToString();
        }
    }
}
