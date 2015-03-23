namespace P04_ExtractArtistsAndNumOfAlbums
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml;

	using DocumentLoader;

	internal class ExtractArtistsAndNumOfAlbums
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();

			XmlNode rootNode = document.DocumentElement;

			Dictionary<string, int> artistsWithNumberOfAlbums = new Dictionary<string, int>();

			if (rootNode != null)
			{
				foreach (XmlNode childNode in rootNode.ChildNodes)
				{
					var artist = childNode["artist"];
					if (artist != null)
					{
						var currentArtist = artist.InnerText;
						int numberOfAlbums = rootNode.ChildNodes.Cast<XmlNode>().Count(
							a =>
								{
									var otherArtist = a["artist"];
									return otherArtist != null && otherArtist.InnerText == currentArtist;
								});

						if (!artistsWithNumberOfAlbums.ContainsKey(currentArtist))
						{
							artistsWithNumberOfAlbums.Add(currentArtist, numberOfAlbums);
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