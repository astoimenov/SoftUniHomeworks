namespace P02BankOfKurtovoKunare
{
    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int period)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(period);
            }
        }
    }
}
