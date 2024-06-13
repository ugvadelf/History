using AgentRating3.Properties;
using System;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AgentRating3
{
	[Database(Name="Gosha")]
	public class AvalonDbDataContext : DataContext
	{
		private static MappingSource mappingSource;

		public Table<CityDictionary> CityDictionaries
		{
			get
			{
				return base.GetTable<CityDictionary>();
			}
		}

		public Table<PrtTypesToPartner> PrtTypesToPartners
		{
			get
			{
				return base.GetTable<PrtTypesToPartner>();
			}
		}

		public Table<tbl_Dogovor> tbl_Dogovors
		{
			get
			{
				return base.GetTable<tbl_Dogovor>();
			}
		}

		public Table<tbl_Partner> tbl_Partners
		{
			get
			{
				return base.GetTable<tbl_Partner>();
			}
		}

		static AvalonDbDataContext()
		{
			AvalonDbDataContext.mappingSource = new AttributeMappingSource();
		}

		public AvalonDbDataContext() : base(Settings.Default.GoshaConnectionString, AvalonDbDataContext.mappingSource)
		{
		}

		public AvalonDbDataContext(string connection) : base(connection, AvalonDbDataContext.mappingSource)
		{
		}

		public AvalonDbDataContext(IDbConnection connection) : base(connection, AvalonDbDataContext.mappingSource)
		{
		}

		public AvalonDbDataContext(string connection, MappingSource mappingSource) : base(connection, mappingSource)
		{
		}

		public AvalonDbDataContext(IDbConnection connection, MappingSource mappingSource) : base(connection, mappingSource)
		{
		}
	}
}