using System;
using System.Collections.Generic;

namespace P01Persons
{
    class PersonsProgram
    {
        static void Main()
        {
            List<Person> persons = new List<Person>(){
                    new Person("Nakov", 25),
                    new Person("Pesho", 33, "peshko@goshkov.bg"),
                    new Person("Gosho", 24, "gosho@"),
                };
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
