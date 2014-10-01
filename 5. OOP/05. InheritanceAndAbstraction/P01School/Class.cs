namespace P01School
{
    using System.Collections.Generic;
    using System.Text;

    public class Class
    {
        private string uniqueText;
        private IEnumerable<Teacher> teachers;
        private string details;

        public Class(string uniqueText, IEnumerable<Teacher> teachers, string details = null)
        {
            this.uniqueText = uniqueText;
            this.teachers = teachers;
            this.details = details;
        }

        public string UniqueText
        {
            get { return this.uniqueText; }
            set { this.uniqueText = value; }
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Class: " + this.uniqueText);
            output.AppendLine("Teachers: ");
            foreach (Teacher teacher in this.teachers)
            {
                output.AppendLine(teacher.ToString());
            }

            if (this.details != null)
            {
                output.AppendLine("Details: " + this.details);
            }

            return output.ToString();
        }
    }
}
