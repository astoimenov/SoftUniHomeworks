namespace DocumentLoader
{
	using System.Xml;

	public class DocumentLoader
	{
		public static XmlDocument LoadXml()
		{
			XmlDocument document = new XmlDocument();
			document.Load("../../../catalog.xml");

			return document;
		}
	}
}