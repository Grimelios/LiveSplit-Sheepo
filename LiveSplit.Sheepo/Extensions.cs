using System.Xml;

namespace LiveSplit.Sheepo
{
	public static class Extensions
	{
		public static XmlElement CreateElement(this XmlDocument document, string tag, object value)
		{
			var element = document.CreateElement(tag);
			element.InnerText = value?.ToString() ?? "";

			return element;
		}
	}
}
