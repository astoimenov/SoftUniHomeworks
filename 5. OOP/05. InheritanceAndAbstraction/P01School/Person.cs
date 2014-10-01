namespace P01School
{
    using System.Text;

    public class Person
    {
        private string name;
        private string details;

        public Person(string name, string details = null)
        {
            this.name = name;
            this.details = details;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Name: " + this.name);
            if (this.details != null)
            {
                output.AppendLine("Details: " + this.details);
            }

            return output.ToString();
        }
    }
}
