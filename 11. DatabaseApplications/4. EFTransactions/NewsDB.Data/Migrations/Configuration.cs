namespace NewsDB.Data.Migrations
{
	using System.Collections.Generic;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<NewsDBContext>
	{
		public Configuration()
		{
			this.AutomaticMigrationsEnabled = true;
			this.AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(NewsDBContext context)
		{
			IList<News> defaultNews = new List<News>();

			defaultNews.Add(
				new News
					{
						Content =
							"Lorem ipsum dolor sit amet, at purus auctor, etiam et amet orci ad tincidunt, lacus egestas nam. Amet risus duis praesent, mattis vel aliquet. Nunc lectus molestie in elementum."
					});
			defaultNews.Add(
				new News { Content = "Dignissim sit mauris vulputate, massa eget lacus pede, nisl in vitae, tellus quisque." });
			defaultNews.Add(
				new News
					{
						Content =
							"Mi elementum aliquet metus ligula hendrerit, justo leo lacus neque egestas, vel at et, sodales lorem vitae sit aliquet."
					});

			foreach (var news in defaultNews)
			{
				context.News.Add(news);
			}

			base.Seed(context);
		}
	}
}