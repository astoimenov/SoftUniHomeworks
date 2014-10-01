namespace P03Animals
{
    using System;

    public class Tomcat : Cat
    {
        private string name;
        private int age;
        private Gender gender;

        public Tomcat(string name, int age) : base(name, age)
        {
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Gender Gender
        {
            get { return Gender.male; }
        }
    }
}
