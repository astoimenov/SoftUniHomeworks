namespace P04CompanyHierarchy
{
    using System;

    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.productName = productName;
            this.date = date;
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
                    throw new ArgumentNullException("Product name can't be null or empty!");
                }
                
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Price can't be negative!");
                    }

                    this.price = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid price!");
                }
            }
        }

        public override string ToString()
        {
            string output = this.productName + ", " + this.date;
            output += ", " + string.Format("{0:##.00}", this.price);
            return output;
        }
    }
}
