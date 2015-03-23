namespace StudentSystem.Data
{
	using System.Data.Entity;

	using Models;

	public class StudentSystemDbContext : DbContext
    {
		public IDbSet<Student> Students { get; set; }

		public IDbSet<Course> Courses { get; set; }

		public IDbSet<Resource> Resources { get; set; }

		public IDbSet<Homework> Homeworks { get; set; }
    }
}
