namespace P08_LinqOldAlbums
{
	using System;
	using System.Linq;
	using System.Xml;
	using System.Xml.Linq;

	using DocumentLoader;

	internal class LinqOldAlbums
	{
		private static void Main()
		{
			XDocument document = XDocument.Load("../../../catalog.xml");

			var oldAlbums = (from album in document.Descendants("album")
			                 where decimal.Parse(album.Element("year").Value) <= (DateTime.Now.Year - 5)
			                 select new
				                        {
					                        Name = album.Element("name").Value,
								 Price = album.Element("price").Value
				                        }
							 ).ToList();
			Console.WriteLine("Albums, published 5 years ago or earlier:");
			foreach (var album in oldAlbums)
			{
				Console.WriteLine("\t{0}, {1} USD", album.Name, album.Price);
			}
		}
	}
}