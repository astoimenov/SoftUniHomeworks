namespace P04CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesEmployee : Employee, ISalesEmployee
    {
        private IEnumerable<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, IEnumerable<Sale> sales) 
            : base(id, firstName, lastName, salary, Department.Sales)
        {
            this.sales = sales;
        }

        public IEnumerable<Sale> Sales
        {
            get
            {
                return this.sales;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Sales collection can't be null!");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += "Sales: \n";
            return this.sales.Aggregate(output, (current, sale) => current + ("\t" + sale.ToString() + "\n"));
        }
    }
}
