using System.Data.Entity.ModelConfiguration;
using NewNews.Model;

namespace NewNews.DAL
{
	public class CodingConfiguration:EntityTypeConfiguration<TCoding>
	{
		public CodingConfiguration()
		{
			Map(a => a.ToTable("T_Coding"));
		}
	}
}
