namespace P01InterestCalculator
{
    using System;

    public class InterestCalculatorProgram
    {
        public static void Main()
        {
            InterestCalculator simpleCalculator = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);
            InterestCalculator compoundCalculator = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);

            Console.WriteLine("Simple interest: \t{0:0.0000}", simpleCalculator.PaybackValue);
            Console.WriteLine("Compound interest: \t{0:0.0000}", compoundCalculator.PaybackValue);
        }

        private static decimal GetSimpleInterest(decimal money, double interest, int years)
        {
            decimal simpleInterest = money * (decimal)(1 + (interest * years / 100));
            return simpleInterest;
        }

        private static decimal GetCompoundInterest(decimal money, double interest, int years)
        {
            decimal compoundInterest = money * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
            return compoundInterest;
        }
    }
}
