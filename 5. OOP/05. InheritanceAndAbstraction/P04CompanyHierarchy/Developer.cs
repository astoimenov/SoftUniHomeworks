namespace P04CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Developer : Employee, IDeveloper
    {
        private IEnumerable<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, IEnumerable<Project> projects) 
            : base(id, firstName, lastName, salary, Department.Production)
        {
            this.projects = projects;
        }

        public IEnumerable<Project> Projects
        {
            get
            {
                return this.projects;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The projects collection can't be null!");
                }
                
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += "Projects: \n";
            return this.projects.Aggregate(
                output, (current, project) => current + ("\t" + project.ToString() + "\n"));
        }
    }
}
