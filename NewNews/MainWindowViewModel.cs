using System;
using System.ComponentModel.Composition;
using Nest;
using NewNews.Infrastructure.Common;

namespace NewNews
{
	[Export(typeof(IMainWindowViewModel))]
	public class MainWindowViewModel:IMainWindowViewModel
	{
		private ElasticClient elasticClient;

		public MainWindowViewModel()
		{
			var node = new Uri("http://localhost:9200");
			var settings = new ConnectionSettings(node);
			settings.DefaultIndex("node-0");
			elasticClient = SingletonFactory<ElasticClient>.Instance(settings);
			LoadNews();
		}

		private void LoadNews()
		{
			var news = new News
			           {
						   Id=2,
						   Headline = "Titre de ma news",
						   Content = "Voici le contenu de ma news",
						   Coding = "WHT"
			           };
			var res = elasticClient.Index(news,f=>f.Index("my_first_index").Id(news.Id.ToString()).Refresh());
			Console.WriteLine("NewsNewTrace --> "+res.DebugInformation);
		}
	}

	internal class News
	{
		public int Id { get; set; }
		public string Headline { get; set; }
		public string Content { get; set; }
		public string Coding { get; set; }
	}

	public interface IMainWindowViewModel
	{
		
	}
}
