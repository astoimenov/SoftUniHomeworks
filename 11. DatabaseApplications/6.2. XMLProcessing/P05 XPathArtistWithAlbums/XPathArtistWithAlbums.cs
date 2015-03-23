namespace P05_XPathArtistWithAlbums
{
	using System;
	using System.Collections.Generic;
	using System.Xml;

	using DocumentLoader;

	internal class XPathArtistWithAlbums
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();
			XmlNodeList artistsNodeList = document.SelectNodes("/catalog/album/artist");
			Dictionary<string, int> artistsWithNumberOfAlbums = new Dictionary<string, int>();

			if (artistsNodeList != null)
			{
				foreach (XmlNode artist in artistsNodeList)
				{
					string currentArtist = artist.InnerText;
					string albumsQuery = string.Format("/catalog/album[artist = \"{0}\"]", currentArtist);
					var albums = document.SelectNodes(albumsQuery);
					if (albums != null)
					{
						var albumsCount = albums.Count;
						if (!artistsWithNumberOfAlbums.ContainsKey(currentArtist))
						{
							artistsWithNumberOfAlbums.Add(currentArtist, albumsCount);
						}
					}
				}
			}

			Console.WriteLine("Artist\t\tAlbums");
			foreach (var pair in artistsWithNumberOfAlbums)
			{
				Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
			}
		}
	}
}