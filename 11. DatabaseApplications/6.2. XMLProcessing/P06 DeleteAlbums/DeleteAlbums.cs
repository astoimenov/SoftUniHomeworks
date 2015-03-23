namespace P06_DeleteAlbums
{
	using System;
	using System.Xml;

	using DocumentLoader;

	internal class DeleteAlbums
	{
		private static void Main()
		{
			XmlDocument document = DocumentLoader.LoadXml();
			XmlNode rootNode = document.DocumentElement;
			if (rootNode != null)
			{
				foreach (XmlNode childNode in rootNode.ChildNodes)
				{
					var price = childNode["price"];
					if (price != null && Decimal.Parse(price.InnerText) > 20)
					{
						childNode.ParentNode?.RemoveChild(childNode);
					}
				}
			}

			document.Save("../../../cheap-albums-catalog.xml");
		}
	}
}