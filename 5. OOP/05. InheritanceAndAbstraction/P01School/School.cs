namespace P01School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student peshko = new Student("Peshko", 5);
            students.Add(peshko);
            Student goshko = new Student("Goshko", 3, "Very good student!");
            students.Add(goshko);

            List<Discipline> disciplines = new List<Discipline>();
            Discipline oop = new Discipline("OOP", 30, students, "Object-oriented programming");
            disciplines.Add(oop);
            Discipline highQualityCode = new Discipline("High Quality Code", 15, students);
            disciplines.Add(highQualityCode);

            List<Teacher> teachers = new List<Teacher>();
            Teacher nakov = new Teacher("Nakov", disciplines);
            teachers.Add(nakov);
            Teacher vlado = new Teacher("Vlado", disciplines);
            teachers.Add(vlado);

            Class theFirstClass = new Class("The First class of SoftUni", teachers);

            Console.WriteLine(theFirstClass);
        }
    }
}
