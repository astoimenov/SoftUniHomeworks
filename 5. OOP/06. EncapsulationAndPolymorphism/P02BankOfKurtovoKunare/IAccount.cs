namespace P02BankOfKurtovoKunare
{
    public interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; }

        decimal InterestRate { get; }

        decimal CalculateInterest(int period);

        void Deposit(decimal amount);
    }
}
