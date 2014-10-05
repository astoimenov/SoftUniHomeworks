namespace P04CompanyHierarchy
{
    using System;

    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.salary = salary;
            this.department = department;
        }

        public Employee(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The salary can't be negative!");
                    }

                    this.salary = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid salary!");
                }
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += string.Format("Salary: {0:##.00}, ", this.salary);
            output += "Department: " + this.department + "\n";
            return output;
        }
    }
}
