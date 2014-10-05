namespace P03Animals
{
    using System;
    using System.Linq;

    public class Animals
    {
        public static void Main()
        {
            Tomcat[] tomcats = new Tomcat[3];
            tomcats[0] = new Tomcat("Tom", 5);
            tomcats[1] = new Tomcat("Jack", 3);
            tomcats[2] = new Tomcat("Bill", 6);
            PrintAverageAge(tomcats);

            Kitten[] kittnes = new Kitten[3];
            kittnes[0] = new Kitten("Kitty", 2);
            kittnes[1] = new Kitten("Mittens", 4);
            kittnes[2] = new Kitten("Molly", 6);
            PrintAverageAge(kittnes);

            Frog[] frogs = new Frog[3];
            frogs[0] = new Frog("Kermit", 5, Gender.male);
            frogs[1] = new Frog("Boko", 7, Gender.male);
            frogs[2] = new Frog("Sara", 9, Gender.female);
            PrintAverageAge(frogs);

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog("Rusty", 1, Gender.male);
            dogs[1] = new Dog("Ares", 2, Gender.male);
            dogs[2] = new Dog("Tera", 4, Gender.female);
            PrintAverageAge(dogs);
        }

        public static void PrintAverageAge(Animal[] animals)
        {
            double averageAge = animals.Average(x => x.Age);
            Console.WriteLine("{0:##.00}", averageAge);
        }
    }
}
