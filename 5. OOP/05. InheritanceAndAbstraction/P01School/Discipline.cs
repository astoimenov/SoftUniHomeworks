namespace P01School
{
    using System.Collections.Generic;
    using System.Text;

    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private IEnumerable<Student> students;
        private string details;

        public Discipline(string name, int numberOfLectures, IEnumerable<Student> students, string details = null)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.students = students;
            this.details = details;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        public IEnumerable<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
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
            output.AppendLine("Number of lectures: " + this.numberOfLectures);
            if (this.details != null)
            {
                output.AppendLine("Details: " + this.details);
            }

            output.AppendLine("Students: ");
            foreach (Student student in this.students)
            {
                output.AppendLine(student.ToString());
            }

            return output.ToString();
        }
    }
}
