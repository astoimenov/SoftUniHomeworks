namespace SoftUniSystem
{
	using System;

	public class EmployeesDAO
	{
		private static readonly SoftUniEntities Context = new SoftUniEntities();

		public static int Add(Employee employee)
		{
			Context.Employees.Add(employee);
			Context.SaveChanges();

			return employee.EmployeeID;
		}

		public static void Update(int employeeId, string propertyName, object newValue)
		{
			var employee = Context.Employees.Find(employeeId);

			if (employee != null)
			{
				employee.GetType().GetProperty(propertyName).SetValue(employee, newValue);
				Context.SaveChanges();
			}
			else
			{
				throw new ArgumentException("The employee doesn't exist.");
			}
		}

		public static void Delete(int employeeId)
		{
			var employee = Context.Employees.Find(employeeId);

			if (employee != null)
			{
				Context.Employees.Remove(employee);
				Context.SaveChanges();
			}
			else
			{
				throw new ArgumentException("The employee doesn't exist.");
			}
		}
	}
}