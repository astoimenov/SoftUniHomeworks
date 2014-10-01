namespace P01School
{
    using System.Text;

    public class Student : Person
    {
        private int classNumber;

        public Student(string name, int classNumber, string details = null) : base(name, details)
        {
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendLine("Class number: " + this.classNumber);
            return output.ToString();
        }
    }
}
