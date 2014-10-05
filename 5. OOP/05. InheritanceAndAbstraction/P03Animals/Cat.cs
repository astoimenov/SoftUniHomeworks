namespace P03Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        protected Cat(string name, int age) 
            : base(name, age)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm cat! Meow!");
        }
    }
}
