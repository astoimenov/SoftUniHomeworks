namespace P01Customer
{
    using System;

    public class Payment
    {
        private string productName;
        private double price;

        public Payment(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name can't be empty!");
                }

                this.productName = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = string.Format("\t{0}, {1:C}", this.productName, this.price);
            return output;
        }
    }
}
