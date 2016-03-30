using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Nest;

namespace NewNews
{
	public class MainWindowViewModel
	{
		public MainWindowViewModel()
		{
			var node = new Uri("http://localhost:9200");
			var settings = new ConnectionSettings(node);
			settings.DefaultIndex("node-0");
			var client = new ElasticClient(settings);
		}
	}
}
