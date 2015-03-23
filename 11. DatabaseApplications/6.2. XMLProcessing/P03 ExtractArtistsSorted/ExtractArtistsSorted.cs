namespace P03_ExtractArtistsSorted
{
	using System;
	using System.Collections.Generic;
	using System.Xml;

	using DocumentLoader;

	internal class ExtractArtistsSorted
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();

			XmlNode rootNode = document.DocumentElement;

			SortedSet<string> artists = new SortedSet<string>();
			if (rootNode != null)
			{
				foreach (XmlNode childNode in rootNode.ChildNodes)
				{
					var artistName = childNode["artist"];
					if (artistName != null)
					{
						artists.Add(artistName.InnerText);
					}
				}
			}

			Console.WriteLine("Artists:");
			foreach (var artist in artists)
			{
				Console.WriteLine("\t{0}", artist);
			}
		}
	}
}