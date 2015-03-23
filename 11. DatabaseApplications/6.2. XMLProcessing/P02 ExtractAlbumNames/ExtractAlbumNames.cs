namespace P02_ExtractAlbumNames
{
	using System;
	using System.Xml;

	using DocumentLoader;

	internal class ExtractAlbumNames
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();

			XmlNode rootNode = document.DocumentElement;

			Console.WriteLine("Albums:");
			if (rootNode != null)
			{
				foreach (XmlNode childNode in rootNode.ChildNodes)
				{
					var albumName = childNode["name"];
					if (albumName != null)
					{
						Console.WriteLine("\t{0}", albumName.InnerText);
					}
				}
			}
		}
	}
}