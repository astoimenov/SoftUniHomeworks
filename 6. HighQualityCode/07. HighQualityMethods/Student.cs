namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string birthPlace;
        private DateTime birthDate;
        private string interests;

        public Student(string firstName, string lastName, string birthPlace, DateTime birthDate, string interests = null)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthPlace = birthPlace;
            this.birthDate = birthDate;
            this.interests = interests;
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
                    throw new ArgumentNullException("The first name can't be empty!");
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
                    throw new ArgumentNullException("The last name can't be empty!");
                }

                this.lastName = value;
            }
        }

        public string BirthPlace
        {
            get
            {
                return this.birthPlace;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The birth place can't be empty!");
                }

                this.birthPlace = value;
            }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string Interests
        {
            get { return this.interests; }
            set { this.interests = value; }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime thisBirthDate = this.birthDate;
            DateTime otherBirthDate = otherStudent.birthDate;
            return thisBirthDate > otherBirthDate;
        }
    }
}
