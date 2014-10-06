namespace P02BankOfKurtovoKunare
{
    using System;
    using System.Collections.Generic;

    public class BankOfKurtovoKunare
    {
        public static void Main()
        {
            const Customer joe = Customer.Individual;
            const Customer intel = Customer.Company;
            
            IAccount mortgageAccInd = new MortgageAccount(joe, 1024m, 5.3m);
            IAccount mortgageAccComp = new MortgageAccount(intel, 1024m, 5.3m);
            IAccount loanAccInd = new LoanAccount(joe, 1024m, 5.3m);
            IAccount loanAccComp = new LoanAccount(intel, 1024m, 5.3m);
            IAccount depositAccIndBig = new DepositAccount(joe, 1024m, 5.3m);
            IAccount depositAccIndSmall = new DepositAccount(joe, 999m, 5.3m);
            IAccount depositAccComp = new DepositAccount(intel, 11024m, 4.3m);

            List<IAccount> accounts = new List<IAccount>()
            {
                mortgageAccInd,
                mortgageAccComp,
                loanAccInd,
                loanAccComp,
                depositAccIndBig,
                depositAccIndSmall,
                depositAccComp
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine(
                    "{5} {0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    acc.GetType().Name,
                    acc.CalculateInterest(2),
                    acc.CalculateInterest(3),
                    acc.CalculateInterest(10),
                    acc.CalculateInterest(13),
                    acc.Customer.GetType().Name);
            }
        }
    }
}
