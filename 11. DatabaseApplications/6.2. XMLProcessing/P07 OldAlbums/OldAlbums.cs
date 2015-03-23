namespace P07_OldAlbums
{
	using System;
	using System.Xml;

	using DocumentLoader;

	internal class OldAlbums
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();
			int yearAfter5Years = DateTime.Now.Year - 5;
			string albumsQuery = string.Format("/catalog/album[year <= {0}]", yearAfter5Years);
			XmlNodeList albumsList = document.SelectNodes(albumsQuery);

			Console.WriteLine("Albums, published 5 years ago or earlier:");
			if (albumsList != null)
			{
				foreach (XmlNode album in albumsList)
				{
					Console.WriteLine("\t{0}, {1} USD", album["name"].InnerText, album["price"].InnerText);
				}
			}
		}
	}
}