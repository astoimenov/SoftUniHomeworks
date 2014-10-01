namespace P02People
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class People
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student sara = new Student("Sara", "Mills", 963147);
            students.Add(sara);
            Student gary = new Student("Gary", "Foster", 987432);
            students.Add(gary);
            Student andrea = new Student("Andrea", "Harper", 951357);
            students.Add(andrea);
            Student lois = new Student("Lois", "Patte", 654753);
            students.Add(lois);
            Student jane = new Student("Jane", "Lopez", 364156);
            students.Add(jane);
            Student tina = new Student("Tina", "Garcia", 1373194);
            students.Add(tina);
            Student linda = new Student("Linda", "Dean", 2668731);
            students.Add(linda);
            Student peter = new Student("Peter", "Grant", 29146136);
            students.Add(peter);
            Student joe = new Student("Joe", "Fisher", 68465164);
            students.Add(joe);
            Student tammy = new Student("Tammy", "Flu", 9874365);
            students.Add(tammy);
            var sortedStudents = students.OrderBy(student => student.FacultyNumber);

            List<Worker> workers = new List<Worker>();
            Worker pesho = new Worker("Pesho", "Ivanov", 35, 7.5);
            workers.Add(pesho);
            Worker ivan = new Worker("Ivan", "Petrov", 49.3, 7.9);
            workers.Add(ivan);
            Worker petkan = new Worker("Petkan", "Dimitrov", 32.8, 8.3);
            workers.Add(petkan);
            Worker gosho = new Worker("Gosho", "Peshov", 39, 8);
            workers.Add(gosho);
            Worker mitko = new Worker("Mitko", "Stamatov", 56, 8.9);
            workers.Add(mitko);
            Worker stamat = new Worker("Stamat", "Mitkov", 47, 7.1);
            workers.Add(stamat);
            Worker unufrii = new Worker("Unufrii", "Cvetanov", 36.5, 8.5);
            workers.Add(unufrii);
            Worker boiko = new Worker("Boiko", "Boikov", 51, 9.2);
            workers.Add(boiko);
            Worker ceco = new Worker("Ceco", "Mishkov", 37.6, 7.86);
            workers.Add(ceco);
            Worker misho = new Worker("Misho", "Pishov", 38.93, 7.65);
            workers.Add(misho);
            var sortedWorkers = from worker in workers
                                orderby worker.PaymentPerHour descending
                                select worker;

            List<Human> resultList = new List<Human>();
            resultList.AddRange(sortedStudents);
            resultList.AddRange(sortedWorkers);

            foreach (Human human in resultList)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
