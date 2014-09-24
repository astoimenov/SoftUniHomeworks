using System;

namespace P01Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Invalid name!");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentOutOfRangeException("Age is outside the allowed range!");
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (null != value && (value.Length == 0 || !value.Contains("@")))
                    throw new ArgumentException("Invalid email!");
                this.email = value;
            }
        }

        public override string ToString()
        {
            string persInfo = string.Format("Name: {0}, age: {1}", this.Name, this.Age);
            string emailOut = this.Email == null ? "" : ", email: " + this.Email;
            string output = persInfo + emailOut;
            return  output;
        }
    }
}
