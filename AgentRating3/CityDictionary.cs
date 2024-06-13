// Decompiled with JetBrains decompiler
// Type: AgentRating3.CityDictionary
// Assembly: AgentRating, Version=3.5.1.0, Culture=neutral, PublicKeyToken=null
// MVID: F060002B-D351-46BE-ABE3-10F01194E01C
// Assembly location: D:\MyProject\AgentRating\bin\Release\AgentRating.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AgentRating3
{
  [Table(Name = "dbo.CityDictionary")]
  public class CityDictionary : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _CT_CNKEY;
    private int _CT_KEY;
    private string _CT_NAME;
    private string _CT_NAMELAT;
    private string _CT_CODE;
    private int _CT_CREATOR;
    private DateTime? _CT_UPDATEDATE;
    private Binary _ROWID;
    private string _CT_StdKey;
    private string _CT_NameAC;
    private int? _CT_Web;
    private int? _CT_RSKey;
    private string _CT_WEBIMAGE;
    private int? _CT_Order;
    private short? _CT_IsDeparture;
    private string _CT_Coordinate;
    private EntitySet<tbl_Partner> _tbl_Partners;

    public CityDictionary() => this._tbl_Partners = new EntitySet<tbl_Partner>(new Action<tbl_Partner>(this.attach_tbl_Partners), new Action<tbl_Partner>(this.detach_tbl_Partners));

    [Column(Storage = "_CT_CNKEY", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int CT_CNKEY
    {
      get => this._CT_CNKEY;
      set
      {
        if (this._CT_CNKEY == value)
          return;
        this.SendPropertyChanging();
        this._CT_CNKEY = value;
        this.SendPropertyChanged(nameof (CT_CNKEY));
      }
    }

    [Column(Storage = "_CT_KEY", DbType = "Int NOT NULL", IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
    public int CT_KEY
    {
      get => this._CT_KEY;
      set
      {
        if (this._CT_KEY == value)
          return;
        this.SendPropertyChanging();
        this._CT_KEY = value;
        this.SendPropertyChanged(nameof (CT_KEY));
      }
    }

    [Column(Storage = "_CT_NAME", DbType = "VarChar(50) NOT NULL", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string CT_NAME
    {
      get => this._CT_NAME;
      set
      {
        if (!(this._CT_NAME != value))
          return;
        this.SendPropertyChanging();
        this._CT_NAME = value;
        this.SendPropertyChanged(nameof (CT_NAME));
      }
    }

    [Column(Storage = "_CT_NAMELAT", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string CT_NAMELAT
    {
      get => this._CT_NAMELAT;
      set
      {
        if (!(this._CT_NAMELAT != value))
          return;
        this.SendPropertyChanging();
        this._CT_NAMELAT = value;
        this.SendPropertyChanged(nameof (CT_NAMELAT));
      }
    }

    [Column(Storage = "_CT_CODE", DbType = "VarChar(3)", UpdateCheck = UpdateCheck.Never)]
    public string CT_CODE
    {
      get => this._CT_CODE;
      set
      {
        if (!(this._CT_CODE != value))
          return;
        this.SendPropertyChanging();
        this._CT_CODE = value;
        this.SendPropertyChanged(nameof (CT_CODE));
      }
    }

    [Column(Storage = "_CT_CREATOR", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int CT_CREATOR
    {
      get => this._CT_CREATOR;
      set
      {
        if (this._CT_CREATOR == value)
          return;
        this.SendPropertyChanging();
        this._CT_CREATOR = value;
        this.SendPropertyChanged(nameof (CT_CREATOR));
      }
    }

    [Column(Storage = "_CT_UPDATEDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? CT_UPDATEDATE
    {
      get => this._CT_UPDATEDATE;
      set
      {
        DateTime? ctUpdatedate = this._CT_UPDATEDATE;
        DateTime? nullable = value;
        if ((ctUpdatedate.HasValue != nullable.HasValue ? 1 : (!ctUpdatedate.HasValue ? 0 : (ctUpdatedate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._CT_UPDATEDATE = value;
        this.SendPropertyChanged(nameof (CT_UPDATEDATE));
      }
    }

    [Column(Storage = "_ROWID", AutoSync = AutoSync.Always, DbType = "rowversion", IsDbGenerated = true, IsVersion = true, UpdateCheck = UpdateCheck.Never)]
    public Binary ROWID
    {
      get => this._ROWID;
      set
      {
        if (!(this._ROWID != value))
          return;
        this.SendPropertyChanging();
        this._ROWID = value;
        this.SendPropertyChanged(nameof (ROWID));
      }
    }

    [Column(Storage = "_CT_StdKey", DbType = "Char(10)", UpdateCheck = UpdateCheck.Never)]
    public string CT_StdKey
    {
      get => this._CT_StdKey;
      set
      {
        if (!(this._CT_StdKey != value))
          return;
        this.SendPropertyChanging();
        this._CT_StdKey = value;
        this.SendPropertyChanged(nameof (CT_StdKey));
      }
    }

    [Column(Storage = "_CT_NameAC", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string CT_NameAC
    {
      get => this._CT_NameAC;
      set
      {
        if (!(this._CT_NameAC != value))
          return;
        this.SendPropertyChanging();
        this._CT_NameAC = value;
        this.SendPropertyChanged(nameof (CT_NameAC));
      }
    }

    [Column(Storage = "_CT_Web", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? CT_Web
    {
      get => this._CT_Web;
      set
      {
        int? ctWeb = this._CT_Web;
        int? nullable = value;
        if ((ctWeb.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ctWeb.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._CT_Web = value;
        this.SendPropertyChanged(nameof (CT_Web));
      }
    }

    [Column(Storage = "_CT_RSKey", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? CT_RSKey
    {
      get => this._CT_RSKey;
      set
      {
        int? ctRsKey = this._CT_RSKey;
        int? nullable = value;
        if ((ctRsKey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ctRsKey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._CT_RSKey = value;
        this.SendPropertyChanged(nameof (CT_RSKey));
      }
    }

    [Column(Storage = "_CT_WEBIMAGE", DbType = "VarChar(64)", UpdateCheck = UpdateCheck.Never)]
    public string CT_WEBIMAGE
    {
      get => this._CT_WEBIMAGE;
      set
      {
        if (!(this._CT_WEBIMAGE != value))
          return;
        this.SendPropertyChanging();
        this._CT_WEBIMAGE = value;
        this.SendPropertyChanged(nameof (CT_WEBIMAGE));
      }
    }

    [Column(Storage = "_CT_Order", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? CT_Order
    {
      get => this._CT_Order;
      set
      {
        int? ctOrder = this._CT_Order;
        int? nullable = value;
        if ((ctOrder.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (ctOrder.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._CT_Order = value;
        this.SendPropertyChanged(nameof (CT_Order));
      }
    }

    [Column(Storage = "_CT_IsDeparture", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? CT_IsDeparture
    {
      get => this._CT_IsDeparture;
      set
      {
        short? ctIsDeparture = this._CT_IsDeparture;
        short? nullable = value;
        if (((int) ctIsDeparture.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (ctIsDeparture.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._CT_IsDeparture = value;
        this.SendPropertyChanged(nameof (CT_IsDeparture));
      }
    }

    [Column(Storage = "_CT_Coordinate", DbType = "VarChar(30)", UpdateCheck = UpdateCheck.Never)]
    public string CT_Coordinate
    {
      get => this._CT_Coordinate;
      set
      {
        if (!(this._CT_Coordinate != value))
          return;
        this.SendPropertyChanging();
        this._CT_Coordinate = value;
        this.SendPropertyChanged(nameof (CT_Coordinate));
      }
    }

    [Association(Name = "CityDictionary_tbl_Partner", Storage = "_tbl_Partners", ThisKey = "CT_KEY", OtherKey = "PR_CTKEY")]
    public EntitySet<tbl_Partner> tbl_Partners
    {
      get => this._tbl_Partners;
      set => this._tbl_Partners.Assign((IEnumerable<tbl_Partner>) value);
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, CityDictionary.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_tbl_Partners(tbl_Partner entity)
    {
      this.SendPropertyChanging();
      entity.CityDictionary = this;
    }

    private void detach_tbl_Partners(tbl_Partner entity)
    {
      this.SendPropertyChanging();
      entity.CityDictionary = (CityDictionary) null;
    }
  }
}
