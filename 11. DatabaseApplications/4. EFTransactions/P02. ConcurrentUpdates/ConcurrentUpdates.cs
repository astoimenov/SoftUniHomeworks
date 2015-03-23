namespace P02.ConcurrentUpdates
{
	using System;
	using System.Data.Entity.Infrastructure;
	using System.Linq;

	using NewsDB.Data;

	public class ConcurrentUpdates
	{
		public static void Main()
		{
			// To test the application you should open 'P02.ConcurrentUpdates.exe'
			// from bin/Debug twice.
			Console.WriteLine("Application started.");

			CorrectNewsContent();
		}

		private static void CorrectNewsContent()
		{
			using (var db = new NewsDBContext())
			{
				var news = db.News.ToList();
				var first = news.First();
				Console.WriteLine("Text from DB: {0}", first.Content);

				Console.WriteLine("Enter the corrected text: ");
				string input = Console.ReadLine();
				first.Content = input;

				try
				{
					db.SaveChanges();

					Console.WriteLine("Changes successfully saved in the DB.");
				}
				catch (DbUpdateConcurrencyException)
				{
					Console.WriteLine("Conflict!");
					CorrectNewsContent();
				}
			}
		}
	}
}