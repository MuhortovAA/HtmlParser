using AngleSharp.Html.Dom;

namespace ParserHtmlApp.Core
{
	public interface IParser<T> where T : class
	{
		T Parse(IHtmlDocument document);
	}
}
