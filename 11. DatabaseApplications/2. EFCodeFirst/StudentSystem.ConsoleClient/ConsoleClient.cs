namespace StudentSystem.ConsoleClient
{
	using System;
	using System.Linq;

	using Data;
	using Models;

	public class ConsoleClient
	{
		public static void Main()
		{
			var db = new StudentSystemDbContext();
		}
	}
}
