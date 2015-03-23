namespace StudentSystem.Models
{
	using System;
	using System.Reflection;

	public static class ExtenstionClass
	{
		public static string GetStringValue(this Enum value)
		{
			Type type = value.GetType();
			FieldInfo fieldInfo = type.GetField(value.ToString());
			EnumStringAttribute[] attribs = fieldInfo.GetCustomAttributes(
				 typeof(EnumStringAttribute), false) as EnumStringAttribute[];
			return attribs.Length > 0 ? attribs[0].StringValue : null;
		}
	}
}