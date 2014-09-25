namespace P03StudentClass
{
    using System;

    public class StudentClass
    {
        public static void Main()
        {
            Student student = new Student("Peter", 22);
            student.PropertyChanged += (sender, eventArgs) => Console.WriteLine(
                "Property changed: {0} (from {1} to {2})",
                eventArgs.Name,
                eventArgs.OldValue,
                eventArgs.NewValue);

            student.Name = "Maria";
            student.Age = 19;
        }
    }
}
