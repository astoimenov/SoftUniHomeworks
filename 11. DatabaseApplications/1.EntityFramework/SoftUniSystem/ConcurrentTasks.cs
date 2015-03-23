namespace SoftUniSystem
{
	using System;

	public class ConcurrentTasks
	{
		public static void PerformConcurrentTasks()
		{
			using (var firstContext = new SoftUniEntities())
			{
				using (var secondContext = new SoftUniEntities())
				{
					firstContext.Employees.Find(5).MiddleName = "Georgiev";
					secondContext.Employees.Find(5).MiddleName = "Petrov";

					firstContext.SaveChanges();
					secondContext.SaveChanges();
				}
			}

			using (var context = new SoftUniEntities())
			{
				var middleName = context.Employees.Find(5).MiddleName;
				Console.WriteLine(middleName);
			}
		}
	}
}