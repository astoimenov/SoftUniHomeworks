namespace StudentSystem.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Resource
	{
		private ICollection<Course> courses;

		public Resource()
		{
			this.courses = new HashSet<Course>();
		}

		public int Id { get; set; }

		[Required(ErrorMessage = "Resource name is required.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Resource type is required.")]
		public ResourceType Type { get; set; }

		[Required(ErrorMessage = "Resource link is required.")]
		public string Link { get; set; }

		public virtual ICollection<Course> Courses
		{
			get
			{
				return this.courses;
			}
			set
			{
				this.courses = value;
			}
		}
	}
}