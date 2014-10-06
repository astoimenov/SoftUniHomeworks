namespace P02BankOfKurtovoKunare
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public virtual decimal CalculateInterest(int periodInMonths)
        {
            decimal interest = this.balance * (1 + this.interestRate * periodInMonths);
            return interest;
        }

        public virtual void Deposit(decimal amount)
        {
            this.balance += amount;
        }
    }
}
