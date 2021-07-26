using ParserHtmlApp.Core;

namespace ParserHtmlApp.Habra
{
	public class HabraSettings : IParserSettings
	{
		public HabraSettings(int start, int end)
		{
			StartPoint = start; EndPoint = end;
		}
		public string BaseUrl { get; set; } = "http://habrahabr.ru";
		public string Prefix { get; set; } = "page{CurrentId}";
		public int StartPoint { get; set; }
		public int EndPoint { get; set; }
	}
}
