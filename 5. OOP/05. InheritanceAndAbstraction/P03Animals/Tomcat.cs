namespace P03Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender = Gender.male) 
            : base(name, age)
        {
        }
    }
}
