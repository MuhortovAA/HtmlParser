using ParserHtmlApp.Core;
using ParserHtmlApp.Habra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserHtmlApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ParserWorker<string[]> parser = new ParserWorker<string[]>(new HabraParser());
			parser.Settings = new HabraSettings(1, 5);
			parser.Start();
			parser.OnCompleted += Parser_OnCompleted;
			parser.OnNewData += Parser_OnNewData;
			Console.ReadLine();

		}

		private static void Parser_OnNewData(object arg1, string[] arg2)
		{
			foreach (var item in arg2)
			{
				Console.WriteLine(item);
			}
		}

		private static void Parser_OnCompleted(object obj)
		{
			Console.WriteLine("***Completed***");
		}
	}
}
