namespace P02People
{
    using System;

    public class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            this.facultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        public override string ToString()
        {
            string output = base.ToString() + "\tFN: " + this.facultyNumber;
            return output;
        }
    }
}
