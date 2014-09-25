namespace P01InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private decimal money;
        private double interest;
        private int years;
        private decimal paybackValue;
        
        public InterestCalculator(decimal money, double interest, int years, CalculateInterest val)
        {
            this.money = money;
            this.interest = interest;
            this.years = years;
            this.paybackValue = val(money, interest, years);
        }

        public delegate decimal CalculateInterest(decimal money, double interest, int years);

        public decimal Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Interest can't be negative!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Period can't be negative!");
                }

                this.years = value;
            }
        }

        public decimal PaybackValue
        {
            get { return this.paybackValue; }
            private set { this.paybackValue = value; }
        }
    }
}
