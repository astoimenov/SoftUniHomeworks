namespace P04CompanyHierarchy
{
    using System;

    public class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("ID can't be negative!");
                    }

                    this.id = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid ID!");
                }
            }
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
                    throw new ArgumentNullException("First name can't be null or empty!");
                }

                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("First name must be between 3 and 20 letters!");
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
                    throw new ArgumentNullException("Last name can't be null or empty!");
                }

                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Last name must be between 3 and 20 letters!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string output = "Name: " + this.firstName + " " + this.lastName;
            output += ", " + this.id + "\n";
            return output;
        }
    }
}
