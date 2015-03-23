namespace SoftUniSystem
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;

	using JsonSql;

	public class SoftUniSystem
	{
		private static readonly SoftUniEntities Context = new SoftUniEntities();

		public static void Main()
		{
			Console.WriteLine("Employees with projects with start date in 2002 year: ");
			var employeesWithProjects = FindEmployeesWithProjects();
			Console.WriteLine("\t" + employeesWithProjects.Count() + " (from method)");

			const string Query =
				"SELECT COUNT(Employees.EmployeeID) FROM Employees " + "JOIN EmployeesProjects "
				+ "ON Employees.EmployeeID = EmployeesProjects.EmployeeID " + "JOIN Projects "
				+ "ON Projects.ProjectID = EmployeesProjects.ProjectID "
				+ "WHERE Projects.StartDate BETWEEN CONVERT(datetime, '2002-01-01') " + "AND CONVERT(datetime, '2002-12-31')"
				+ "GROUP BY Employees.EmployeeID";

			var result = Context.Database.SqlQuery<object>(Query);

			Console.WriteLine("\t" + result.Count() + " (with native SQL)");

			var employeesByDepartmentAndManager = FindEmployeesByDepartmentAndManager("Purchasing", "Sheela", "Word");

			Console.WriteLine("Employees from 'Purchasing' department with manager - Sheela Word");
			Console.WriteLine("\t" + employeesByDepartmentAndManager.Count());

			ConcurrentTasks.PerformConcurrentTasks();

			var employeesForProject = Context.Employees.Take(5).ToList();
			var newProject = AddProject("Test project", new DateTime(2015, 1, 1), DateTime.Now, employeesForProject);

			if (null != newProject)
			{
				Console.WriteLine("Project {0} successfully added", newProject.Name);
			}
			else
			{
				throw new InvalidOperationException("Project adding has failed.");
			}

			var projectsCount = GetProjectsCountByEmployee("Guy", "Gilbert");
			Console.WriteLine("Guy Gilbert projects: {0}", projectsCount);

			JsonSqlManager js = new JsonSqlManager
				                    {
					                    ConnectionString =
						                    "Server=WIN-DIG1VDBR7U9;Database=SoftUni;"
						                    + "User Id=WIN-DIG1VDBR7U9\\Alexander;Integrated Security=true;"
				                    };

			js.SqlToJson("select * from Employees", CommandType.Text);
			var json = js.JsonResult;
			System.IO.File.WriteAllText(@"D:\bla.json", json);

			// BsonDocument document = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(json);
		}

		public static IQueryable<Employee> FindEmployeesWithProjects()
		{
			var employees = Context.Employees.Where(e => e.Projects.Any(p => p.StartDate.Year == 2002));

			return employees;
		}

		public static IQueryable<Employee> FindEmployeesByDepartmentAndManager(
			string department, 
			string managerFirstName, 
			string managerLastName)
		{
			var employees =
				Context.Employees.Where(employee => employee.Department.Name == department)
					.Where(e => e.Manager.FirstName == managerFirstName && e.Manager.LastName == managerLastName);

			return employees;
		}

		public static Project AddProject(
			string projectName, 
			DateTime startDate, 
			DateTime endDate, 
			ICollection<Employee> employees)
		{
			using (Context)
			{
				using (var newProjectTransaction = Context.Database.BeginTransaction())
				{
					var project = new Project();
					try
					{
						project.Name = projectName;
						project.StartDate = startDate;
						project.EndDate = endDate;
						project.Employees = employees;

						project = Context.Projects.Add(project);
						Context.SaveChanges();
						newProjectTransaction.Commit();
					}
					catch (Exception)
					{
						newProjectTransaction.Rollback();
					}

					return project;
				}
			}
		}

		public static int GetProjectsCountByEmployee(string firstName, string lastName)
		{
			using (var softuniDbContext = new SoftUniEntities())
			{
				var count = softuniDbContext.usp_GetProjectsCountByEmployee(firstName, lastName).FirstOrDefault();
				if (count == null)
				{
					throw new InvalidOperationException("Can't get projects count.");
				}

				return count.Value;
			}
		}
	}
}