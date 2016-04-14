using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Data;
using System.Windows.Documents;
using NewNews.BLL;
using NewNews.Model;
using Prism.Commands;

namespace NewNews
{
	[Export(typeof(IMainWindowViewModel))]
	public class MainWindowViewModel : IMainWindowViewModel
	{
		private Elastic elasticClient;

		// L'index doit obligatoirement être en minuscule
		News newsWheat = new News
		{
			Id = 2,
			Index = "index_rapeseed",
			Headline = "Titre de ma news",
			Content = "Voici le contenu de ma news",
			Coding = "WHT"
		};
		News newsCorn = new News
		{
			Id = 2,
			Index = "index_rapeseedoil",
			Headline = "Titre de ma news",
			Content = "Voici le contenu de ma news",
			Coding = "CORN"
		};

		public MainWindowViewModel()
		{
			elasticClient = new Elastic();
			DocumentList = new ObservableCollection<News>();
			BindingOperations.EnableCollectionSynchronization(DocumentList, new object());
			LoadNews();
		}

		private void LoadNews()
		{
			//elasticClient.Send(newsWheat);
			//elasticClient.Send(newsCorn);
		}

		private DelegateCommand _searchCommand;
		public DelegateCommand SearchCommand
		{
			get
			{
				return _searchCommand ?? (_searchCommand = new DelegateCommand(() =>
																		 {
																			 var resGet = elasticClient.Search(indexEnum.index_wheat.ToString());
																			 DocumentList.AddRange(resGet.Documents.ToList());
																		 }));
			}
		}

		private DelegateCommand _getCommand;

		public DelegateCommand GetCommand
		{
			get
			{
				return _getCommand ?? (_getCommand = new DelegateCommand(() =>
				{
					//var resGet = elasticClient.
					//DocumentList.AddRange(resGet.Documents.ToList());
				}));
			}
		}

		public ObservableCollection<News> DocumentList { get; set; }

		private string _titre { get; set; }

		public string Titre
		{
			get
			{
				return _titre;
			}
			set
			{
				_titre = value;
			}
		}
	}

	public enum indexEnum
	{
		index_wheat,
		index_corn,
		index_rapeseed,
		index_rapeseedoil
	}
}
