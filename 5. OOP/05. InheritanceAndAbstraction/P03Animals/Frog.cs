﻿namespace P03Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm frog! Croak!");
        }
    }
}
