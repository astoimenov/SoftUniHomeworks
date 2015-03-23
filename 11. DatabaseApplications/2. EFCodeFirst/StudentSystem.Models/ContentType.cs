namespace StudentSystem.Models
{
	public enum ContentType
	{
		[EnumString("application/zip")]
		Zip,
		[EnumString("application/7z")]
		SevenZ,
		[EnumString("application/pdf")]
		Pdf,
		[EnumString("application/doc")]
		Doc
	}
}