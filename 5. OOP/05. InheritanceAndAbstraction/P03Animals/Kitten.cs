namespace P03Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender = Gender.female) 
            : base(name, age)
        {
        }
    }
}
