namespace P03Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
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
            get { return this.gender; }
            set { this.gender = value; }
        }

        public override string ToString()
        {
            string output = string.Format("{0}, {1}, {2}", this.name, this.age, this.gender);
            return output;
        }
    }
}
