namespace NewsDB.ConsoleClient
{
	using Data;

	public class Program
	{
		public static void Main()
		{
			using (var db = new NewsDBContext())
			{
				db.News.Add(new News { Content = "Some very long and interesting content!" });

				db.SaveChanges();
			}
		}
	}
}