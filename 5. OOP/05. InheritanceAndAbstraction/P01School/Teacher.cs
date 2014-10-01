namespace P01School
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        private IEnumerable<Discipline> disciplines;

        public Teacher(string name, IEnumerable<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.disciplines = disciplines;
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendLine("Disciplines: ");
            foreach (Discipline discipline in this.disciplines)
            {
                output.AppendLine(discipline.ToString());
            }

            return output.ToString();
        }
    }
}
