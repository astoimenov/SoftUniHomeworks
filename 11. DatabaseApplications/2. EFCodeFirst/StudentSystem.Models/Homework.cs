namespace StudentSystem.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Homework
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Homework content is required")]
		public string Content { get; set; }

		public ContentType Type { get; set; }

		public DateTime DateTime { get; set; }

		public int StudentId { get; set; }

		public virtual Student Student { get; set; }

		public int CourseId { get; set; }

		public virtual Course Course { get; set; }
	}
}