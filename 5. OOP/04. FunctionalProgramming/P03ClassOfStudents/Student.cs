namespace P03ClassOfStudents
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.facultyNumber = facultyNumber;
            this.phone = phone;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
        }

        public Student()
        {
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can't be null or empty!");
                }

                if (value.Length < 3 || value.Length > 20 || string.Compare(value.GetType().ToString(), "string") == 0)
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can't be null or empty!");
                }

                if (value.Length < 3 || value.Length > 20 || string.Compare(value.GetType().ToString(), "string") == 0)
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age can't be negative!");
                }
                
                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                const string PhonePattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
                if (!Regex.IsMatch(value, PhonePattern))
                {
                    throw new ArgumentException("Invalid phone!");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                const string EmailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (!Regex.IsMatch(value, EmailPattern))
                {
                    throw new ArgumentException("Invalid email!");
                }

                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public static void PrintStudentFromCollection(IEnumerable<Student> collection)
        {
            foreach (Student student in collection)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public override string ToString()
        {
            string marksToString = string.Join(", ", this.marks);
            return string.Format(
                "{0} {1}, FN: {2}, group: {3}, age: {4}, phone: {5}, email: {6}, marks: {{ {7} }}",
                this.firstName,
                this.lastName,
                this.facultyNumber,
                this.groupNumber,
                this.age,
                this.phone,
                this.email,
                marksToString);
        }
    }
}
