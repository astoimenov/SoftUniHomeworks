namespace NewsDB.Data
{
	using System.Data.Entity;

	using Migrations;

	public class NewsDBContext : DbContext
	{
		public NewsDBContext()
			: base("News")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDBContext, Configuration>("News"));
		}

		public IDbSet<News> News { get; set; }
	}
}