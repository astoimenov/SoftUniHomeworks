namespace P04CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class CompanyHierarchy
    {
        public static void Main()
        {
            Sale office = new Sale("Office 13", DateTime.UtcNow, (decimal)256.15);
            Sale windows = new Sale("Windows 10", DateTime.UtcNow, 10);
            List<Sale> sales = new List<Sale>()
            {
                office, 
                windows
            };
            SalesEmployee jack = new SalesEmployee(167943, "Jack", "Petrov", 800, sales);

            Project facebook = new Project("Facebook", DateTime.Now, "Social media", ProjectState.Open);
            Project github = new Project("GitHub", new DateTime(2013, 9, 5), "Source control system", ProjectState.Closed);
            List<Project> projects = new List<Project>()
            {
                facebook,
                github
            };
            Developer ninja = new Developer(888222, "PHP", "Ninja", 5001, projects);

            List<Employee> employees = new List<Employee>()
            {
                jack,
                ninja
            };

            Manager joe = new Manager(153794, "Joe", "Ivanov", (decimal)852.36, employees);

            List<Employee> companyEmployees = new List<Employee>()
            {
                jack,
                ninja,
                joe
            };

            foreach (Employee employee in companyEmployees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
