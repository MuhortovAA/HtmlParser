using AngleSharp.Html.Dom;
using ParserHtmlApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserHtmlApp.Habra
{
	public class HabraParser : IParser<string[]>
	{
		public string[] Parse(IHtmlDocument document)
		{
			var list = new List<string>();
			var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("tm-article-snippet__title-link"));
			foreach (var item in items)
			{
				list.Add(item.TextContent);
			}
			return list.ToArray();
		}
	}
}
