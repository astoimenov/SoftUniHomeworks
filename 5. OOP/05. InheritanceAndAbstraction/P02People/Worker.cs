namespace P02People
{
    using System.Text;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public double PaymentPerHour
        {
            get { return this.MoneyPerHour(); }
        }

        public double MoneyPerHour()
        {
            double money = this.weekSalary / (this.workHoursPerDay * 5.0);
            return money;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendLine(string.Format(
                "Week salary: {0}, Work hours/day: {1}", this.weekSalary, this.workHoursPerDay));
            output.AppendLine(string.Format("Money/hour: {0:##.00}", this.PaymentPerHour));
            return output.ToString();
        }
    }
}
