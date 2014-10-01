namespace P03Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        protected Cat(string name, int age) : base(name, age)
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
            get { return this.gender; }
            set { this.gender = value; }
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm cat! Meow!");
        }
    }
}
