namespace P02BankOfKurtovoKunare
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Customer == Customer.Individual)
            {
                if (period >= 3)
                {
                    return base.CalculateInterest(period - 3);
                }

                return this.Balance;
            }
            if (this.Customer == Customer.Company)
            {
                if (period >= 2)
                {
                    return base.CalculateInterest(period - 2);
                }

                return this.Balance;
            }

            return base.CalculateInterest(period);
        }
    }
}
