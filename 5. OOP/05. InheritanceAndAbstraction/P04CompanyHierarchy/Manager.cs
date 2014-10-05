namespace P04CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Manager : Employee, IManager
    {
        private IEnumerable<Employee> employees;

        public Manager(int id, string firstName, string lastName, decimal salary, IEnumerable<Employee> employees)
            : base(id, firstName, lastName, salary)
        {
            this.employees = employees;
        }

        public IEnumerable<Employee> Employees
        {
            get
            {
                return this.employees;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Employees collection can't be null!");
                }

                this.employees = value;
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += "Employees: " + "\n";
            foreach (Employee employee in this.employees)
            {
                output += "\t" + employee.FirstName + " " + employee.LastName;
                output += ", " + employee.Id + "\n";
            }

            return output;
        }
    }
}
