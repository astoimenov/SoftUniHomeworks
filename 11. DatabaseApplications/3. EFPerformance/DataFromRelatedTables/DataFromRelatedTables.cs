namespace DataFromRelatedTables
{
	using System;
	using System.Data.Entity;

	using Ads;

	public class DataFromRelatedTables
	{
		public static void Main()
		{
			var adsEntities = new AdsEntities();
			var ads = adsEntities.Ads;

			/*foreach (var ad in ads)
			{
				Console.WriteLine("Title: {0} ({1})", ad.Title, ad.AdStatus.Status);
				Console.WriteLine("Category: {0}", ad.Category == null ? "(no category)" : ad.Category.Name);
				Console.WriteLine("Town: {0}", ad.Town == null ? "(no town)" : ad.Town.Name);
				Console.WriteLine("User: {0}", ad.AspNetUser.Name);
				Console.WriteLine();
			}*/

			foreach (var ad in ads.Include(a => a.AdStatus)
						.Include(a => a.Town)
						.Include(a => a.Category)
						.Include(a => a.AspNetUser))
			{
				Console.WriteLine("Title: {0} ({1})", ad.Title, ad.AdStatus.Status);
				Console.WriteLine("Category: {0}", ad.Category == null ? "(no category)" : ad.Category.Name);
				Console.WriteLine("Town: {0}", ad.Town == null ? "(no town)" : ad.Town.Name);
				Console.WriteLine("User: {0}", ad.AspNetUser.Name);
				Console.WriteLine();
			}
		}
	}
}
