namespace P02BankOfKurtovoKunare
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Customer == Customer.Individual)
            {
                if (period >= 6)
                {
                    return base.CalculateInterest(period - 6);
                }

                return this.Balance;
            }
            if (this.Customer == Customer.Company)
            {
                if (period <= 12)
                {
                    return base.CalculateInterest(period) / 2;
                }

                return (base.CalculateInterest(12) / 2) + base.CalculateInterest(period - 12);
            }

            return base.CalculateInterest(period);
        }
    }
}
