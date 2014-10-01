namespace P03ClassOfStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClassOfStudents
    {
        public static void Main()
        {
            IList<int> marks1 = new List<int>() { 6, 5, 3, 4, 5, 2 };
            IList<int> marks2 = new List<int>() { 5, 2, 4, 3, 5, 2 };

            List<Student> students = new List<Student>();

            Student sara = new Student(
                "Sara", "Mills", 22, 48842536,
                "+359-888-88-88-88", "smills0@abv.bg",
                marks1, 2);
            students.Add(sara);
            Student daniel = new Student(
                "Alex", "Carter", 35, 101214009,
                "0888987654", "dcarter1@buzzfeed.com",
                marks2, 1);
            students.Add(daniel);
            Student aaron = new Student(
                "Alex", "Gibson", 15, 1256783,
                "956-34-35", "agibson2@house.gov",
                marks2, 2);
            students.Add(aaron);
            Student bill = new Student(
                "William", "Alexander", 20, 9513577,
                "02/9317594", "walexander3@abv.bg",
                marks1, 3);
            students.Add(bill);
            Student mildy = new Student(
                "Mildred", "Hansen", 24, 8526548,
                "555-55-55", "mhansen4@skype.com",
                marks2, 3);
            students.Add(mildy);

            Console.WriteLine("All students:");
            Student.PrintStudentFromCollection(students);
            Console.WriteLine();

            /* --- Problem 4. Students by Group --- */
            Console.WriteLine("All students from group 2:");
            var byGroup = from student in students
                          where student.GroupNumber == 2
                          orderby student.FirstName
                          select student;
            Student.PrintStudentFromCollection(byGroup);
            Console.WriteLine();

            /* --- Problem 5. Students by First and Last Name --- */
            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            var compareNames = from student in students
                               where student.FirstName.CompareTo(student.LastName) < 0
                               select student;
            Student.PrintStudentFromCollection(compareNames);
            Console.WriteLine();

            /* --- Problem 6. Students by Age --- */
            Console.WriteLine("The first name and last name of all students with age between 18 and 24:");
            var byAge = from student in students
                        where student.Age >= 18 && student.Age <= 24
                        select new { student.FirstName, student.LastName };
            foreach (var item in byAge)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine();

            /* --- Problem 7. Sort Students with Lambda --- */
            Console.WriteLine("The students sorted by first name and last name in descending order ( with lambda ):");
            var sortedLambda = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Student.PrintStudentFromCollection(sortedLambda);
            Console.WriteLine();

            /* --- Problem 7. Sort Students with LINQ --- */
            Console.WriteLine("The students sorted by first name and last name in descending order ( with LINQ ):");
            var sortedLinq = from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;
            Student.PrintStudentFromCollection(sortedLinq);
            Console.WriteLine();

            /* --- Problem 8. Filter Students by Email Domain --- */
            Console.WriteLine("All students that have email @abv.bg:");
            var atAbv = from student in students
                        where student.Email.Contains("@abv.bg")
                        select student;
            Student.PrintStudentFromCollection(atAbv);
            Console.WriteLine();

            /* --- Problem 9. Filter Students by Phone --- */
            Console.WriteLine("All students with phones in Sofia:");
            var phonesInSofia = from student in students
                                where
                                    student.Phone.StartsWith("02") ||
                                    student.Phone.StartsWith("+3592") ||
                                    student.Phone.StartsWith("+359 2")
                                select student;
            Student.PrintStudentFromCollection(phonesInSofia);
            Console.WriteLine();

            /* --- Problem 10. Excellent Students --- */
            Console.WriteLine("All students that have at least one mark Excellent (6):");
            var excellentStudents = from student in students
                                    where student.Marks.Contains(6)
                                    select new
                                    {
                                        student.FirstName, 
                                        student.LastName,
                                        student.Marks
                                    };
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(
                    "{0} {1}, marks: {{ {2} }}", 
                    student.FirstName, student.LastName, 
                    string.Join(", ", student.Marks));
            }

            /* --- Problem 11. Weak Students --- */
            Console.WriteLine();
            Console.WriteLine("All students with exactly two marks (2):");
            var weakStudents = students.Where(student => student.Marks.Count(mark => mark == 2) == 2);
            foreach (Student student in weakStudents)
            {
                Console.WriteLine(
                    "{0} {1}, marks: {{ {2} }}",
                    student.FirstName, student.LastName, 
                    string.Join(", ", student.Marks));
            }

            /* --- Problem 12. Students Enrolled in 2014 --- */
            Console.WriteLine();
            Console.WriteLine("Marks of the students that enrolled in 2014:");
            var enrolledIn2014 = students.Where(
                student => student.FacultyNumber.ToString().Substring(4, 2) == "14");
            foreach (Student student in enrolledIn2014)
            {
                Console.WriteLine(string.Join(", ", student.Marks));
            }
        }
    }
}
