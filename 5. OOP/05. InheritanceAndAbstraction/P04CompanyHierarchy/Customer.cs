namespace P04CompanyHierarchy
{
    using System;

    public class Customer : Person, ICustomer
    {
        private decimal purchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal purchaseAmount) 
            : base(id, firstName, lastName)
        {
            this.purchaseAmount = purchaseAmount;
        }

        public decimal PurchaseAmount
        {
            get
            {
                return this.purchaseAmount;
            }

            set
            {
                try
                {
                    this.purchaseAmount = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid amount!");
                }
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += "Purchase amount: " + string.Format("{0:##.00}", this.purchaseAmount);
            return output;
        }
    }
}
