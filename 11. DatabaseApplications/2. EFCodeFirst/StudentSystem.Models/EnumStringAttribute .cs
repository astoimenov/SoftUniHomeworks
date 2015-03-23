namespace StudentSystem.Models
{
	using System;

	public class EnumStringAttribute : Attribute
	{
		public EnumStringAttribute(string stringValue)
		{
			this.StringValue = stringValue;
		}

		public string StringValue { get; set; }
	}
}