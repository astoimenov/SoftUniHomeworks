namespace P03Animals
{
    using System;
    using System.Linq;

    public class Animals
    {
        public static void Main()
        {
            Dog sharo = new Dog("Sharo", 3, Gender.male);
            sharo.ProduceSound();
        }
    }
}
