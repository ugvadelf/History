using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Threading;

namespace AgentRating3
{
	[Table(Name="dbo.PrtTypesToPartners")]
	public class PrtTypesToPartner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs;

		private int _PTP_Id;

		private int _PTP_PRKey;

		private int _PTP_PTId;

		private EntityRef<AgentRating3.tbl_Partner> _tbl_Partner;

		[Column(Storage="_PTP_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PTP_Id
		{
			get
			{
				return this._PTP_Id;
			}
			set
			{
				if (this._PTP_Id != value)
				{
					this.SendPropertyChanging();
					this._PTP_Id = value;
					this.SendPropertyChanged("PTP_Id");
				}
			}
		}

		[Column(Storage="_PTP_PRKey", DbType="Int NOT NULL")]
		public int PTP_PRKey
		{
			get
			{
				return this._PTP_PRKey;
			}
			set
			{
				if (this._PTP_PRKey != value)
				{
					if (this._tbl_Partner.HasLoadedOrAssignedValue)
					{
						throw new ForeignKeyReferenceAlreadyHasValueException();
					}
					this.SendPropertyChanging();
					this._PTP_PRKey = value;
					this.SendPropertyChanged("PTP_PRKey");
				}
			}
		}

		[Column(Storage="_PTP_PTId", DbType="Int NOT NULL")]
		public int PTP_PTId
		{
			get
			{
				return this._PTP_PTId;
			}
			set
			{
				if (this._PTP_PTId != value)
				{
					this.SendPropertyChanging();
					this._PTP_PTId = value;
					this.SendPropertyChanged("PTP_PTId");
				}
			}
		}

		[Association(Name="tbl_Partner_PrtTypesToPartner", Storage="_tbl_Partner", ThisKey="PTP_PRKey", OtherKey="PR_KEY", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AgentRating3.tbl_Partner tbl_Partner
		{
			get
			{
				return this._tbl_Partner.Entity;
			}
			set
			{
				AgentRating3.tbl_Partner entity = this._tbl_Partner.Entity;
				if ((entity != value ? true : !this._tbl_Partner.HasLoadedOrAssignedValue))
				{
					this.SendPropertyChanging();
					if (entity != null)
					{
						this._tbl_Partner.Entity = null;
						entity.PrtTypesToPartners.Remove(this);
					}
					this._tbl_Partner.Entity = value;
					if (value == null)
					{
						this._PTP_PRKey = 0;
					}
					else
					{
						value.PrtTypesToPartners.Add(this);
						this._PTP_PRKey = value.PR_KEY;
					}
					this.SendPropertyChanged("tbl_Partner");
				}
			}
		}

		static PrtTypesToPartner()
		{
			PrtTypesToPartner.emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
		}

		public PrtTypesToPartner()
		{
			this._tbl_Partner = new EntityRef<AgentRating3.tbl_Partner>();
		}

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		protected virtual void SendPropertyChanging()
		{
			if (this.PropertyChanging != null)
			{
				this.PropertyChanging(this, PrtTypesToPartner.emptyChangingEventArgs);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public event PropertyChangingEventHandler PropertyChanging;
	}
}