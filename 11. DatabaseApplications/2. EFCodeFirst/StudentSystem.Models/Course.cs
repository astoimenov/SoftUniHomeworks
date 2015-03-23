namespace StudentSystem.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Course
	{
		private ICollection<Student> students;

		private ICollection<Resource> resources;

		private ICollection<Homework> homeworkSubmissions;

		public Course()
		{
			this.students = new HashSet<Student>();
			this.resources = new HashSet<Resource>();
			this.homeworkSubmissions = new HashSet<Homework>();
		}

		public int Id { get; set; }

		[Required(ErrorMessage = "Course name is required.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Course description is required.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Course start date is required.")]
		public DateTime StartDate { get; set; }

		[Required(ErrorMessage = "Course end date is required.")]
		public DateTime EndDate { get; set; }

		[Required(ErrorMessage = "Course end date is required.")]
		[Range(0, double.MaxValue, ErrorMessage = "Price must be positive number.")]
		public double Price { get; set; }

		public virtual ICollection<Student> Students
		{
			get
			{
				return this.students;
			}

			set
			{
				this.students = value;
			}
		}

		public virtual ICollection<Resource> Resources
		{
			get
			{
				return this.resources;
			}

			set
			{
				this.resources = value;
			}
		}

		public virtual ICollection<Homework> HomeworkSubmissions
		{
			get
			{
				return this.homeworkSubmissions;
			}

			set
			{
				this.homeworkSubmissions = value;
			}
		}
	}
}