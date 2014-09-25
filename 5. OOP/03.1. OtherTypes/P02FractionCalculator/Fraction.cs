namespace P02FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                try
                {
                    this.numerator = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid numerator!");
                }
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new ArgumentException("Invalid denominator!");
                    }

                    this.denominator = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid denominator!");
                }
            }
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            long denomominator = f1.denominator * f2.denominator;
            return new Fraction(numerator, denomominator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long numerator = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            long denomominator = f1.denominator * f2.denominator;
            return new Fraction(numerator, denomominator);
        }

        public override string ToString()
        {
            return ((decimal)this.numerator / this.denominator).ToString();
        }
    }
}
