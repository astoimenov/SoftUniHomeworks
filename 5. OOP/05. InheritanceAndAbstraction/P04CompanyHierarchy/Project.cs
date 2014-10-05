namespace P04CompanyHierarchy
{
    using System;

    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string name, DateTime startDate, string details, ProjectState state)
        {
            this.name = name;
            this.startDate = startDate;
            this.details = details;
            this.state = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name can't be null or empty!");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project details can't be null or empty!");
                }

                this.details = value;
            }
        }

        public ProjectState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            this.state = ProjectState.Closed;
        }

        public override string ToString()
        {
            string output = this.name + ", " + this.startDate + "\n";
            output += "\tDetails: " + this.details + ", " + this.state;
            return output;
        }
    }
}
