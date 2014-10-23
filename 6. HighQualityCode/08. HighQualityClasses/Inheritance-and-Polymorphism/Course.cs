namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        protected Course(string name)
        {
            this.name = name;
        }

        protected Course(string name, string teacherName, IList<string> students)
        {
            this.name = name;
            this.teacherName = teacherName;
            this.students = students;
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
                    throw new ArgumentNullException("Name can't be empty!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher's name can't be empty!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.name);
            if (this.teacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.teacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.students) + " }";
        }
    }
}
