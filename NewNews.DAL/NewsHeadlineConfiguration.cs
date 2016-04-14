using System.Data.Entity.ModelConfiguration;
using NewNews.Model;

namespace NewNews.DAL
{
	public class NewsHeadlineConfiguration:EntityTypeConfiguration<NewsHeadline>
	{
		public NewsHeadlineConfiguration()
		{
			Map(a=>a.ToTable("NewsHeadline"));
		}
	}
}
