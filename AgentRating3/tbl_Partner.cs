// Decompiled with JetBrains decompiler
// Type: AgentRating3.tbl_Partner
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
  [Table(Name = "dbo.tbl_Partners")]
  public class tbl_Partner : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _PR_KEY;
    private string _PR_FULLNAME;
    private string _PR_NAME;
    private string _PR_NAMEENG;
    private string _PR_BOSSNAME;
    private string _PR_BOSS;
    private short? _PR_MALE;
    private string _PR_MAINMEN;
    private string _PR_MAINMENPHONE;
    private double? _PR_DISCOUNT;
    private string _PR_ACCOUNT;
    private string _PR_ADRESS;
    private string _PR_PHONES;
    private string _PR_FAX;
    private string _PR_EMAIL;
    private int? _PR_CTKEY;
    private int _PR_CREATOR;
    private string _PR_AGENTDOGOVOR;
    private long? _PR_TYPE;
    private string _PR_CITY;
    private int? _PR_WEBAGENT;
    private DateTime? _PR_AGENTDATE;
    private string _PR_AGENTDOGOVOR2;
    private DateTime? _PR_AGENTDATE2;
    private string _PR_FAX1;
    private string _PR_REMARK;
    private DateTime? _PR_CREATEDATE;
    private DateTime? _PR_UPDATEDATE;
    private int? _PR_ART;
    private int? _PR_USERLAST;
    private string _PR_COD;
    private Binary _ROWID;
    private int _PR_Filial;
    private DateTime? _PR_DateLastContact;
    private string _PR_ExchangePwd;
    private string _PR_GUID;
    private Binary _PR_ExchangeData;
    private short _PR_DOGOVORTYPE;
    private string _PR_ICQ;
    private string _PR_GDS_PREFIX;
    private string _PR_GDS_SUFFIX;
    private int? _PR_OWNER;
    private string _PR_IPAddress;
    private string _PR_Description;
    private short _PR_Deleted;
    private string _PR_LICENSENUMBER;
    private string _PR_ADDITIONALINFO;
    private string _PR_LEGALADDRESS;
    private string _PR_INN;
    private string _PR_FOREIGNACCINFO;
    private string _PR_KPP;
    private string _PR_CODEOKONH;
    private string _PR_CODEOKPO;
    private string _PR_HOMEPAGE;
    private int _PR_PGKEY;
    private short _PR_BLOCKEDFORANNUL;
    private string _PR_POSTINDEX;
    private string _PR_LEGALPOSTINDEX;
    private string _PR_RegisterSeries;
    private string _PR_RegisterNumber;
    private string _PR_WebServiceUrl;
    private bool _PR_PrivatePerson;
    private EntitySet<tbl_Dogovor> _tbl_Dogovors;
    private EntitySet<PrtTypesToPartner> _PrtTypesToPartners;
    private EntityRef<CityDictionary> _CityDictionary;

    public tbl_Partner()
    {
      this._tbl_Dogovors = new EntitySet<tbl_Dogovor>(new Action<tbl_Dogovor>(this.attach_tbl_Dogovors), new Action<tbl_Dogovor>(this.detach_tbl_Dogovors));
      this._PrtTypesToPartners = new EntitySet<PrtTypesToPartner>(new Action<PrtTypesToPartner>(this.attach_PrtTypesToPartners), new Action<PrtTypesToPartner>(this.detach_PrtTypesToPartners));
      this._CityDictionary = new EntityRef<CityDictionary>();
    }

    [Column(Storage = "_PR_KEY", DbType = "Int NOT NULL", IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
    public int PR_KEY
    {
      get => this._PR_KEY;
      set
      {
        if (this._PR_KEY == value)
          return;
        this.SendPropertyChanging();
        this._PR_KEY = value;
        this.SendPropertyChanged(nameof (PR_KEY));
      }
    }

    [Column(Storage = "_PR_FULLNAME", DbType = "VarChar(160)", UpdateCheck = UpdateCheck.Never)]
    public string PR_FULLNAME
    {
      get => this._PR_FULLNAME;
      set
      {
        if (!(this._PR_FULLNAME != value))
          return;
        this.SendPropertyChanging();
        this._PR_FULLNAME = value;
        this.SendPropertyChanged(nameof (PR_FULLNAME));
      }
    }

    [Column(Storage = "_PR_NAME", DbType = "VarChar(140)", UpdateCheck = UpdateCheck.Never)]
    public string PR_NAME
    {
      get => this._PR_NAME;
      set
      {
        if (!(this._PR_NAME != value))
          return;
        this.SendPropertyChanging();
        this._PR_NAME = value;
        this.SendPropertyChanged(nameof (PR_NAME));
      }
    }

    [Column(Storage = "_PR_NAMEENG", DbType = "VarChar(80)", UpdateCheck = UpdateCheck.Never)]
    public string PR_NAMEENG
    {
      get => this._PR_NAMEENG;
      set
      {
        if (!(this._PR_NAMEENG != value))
          return;
        this.SendPropertyChanging();
        this._PR_NAMEENG = value;
        this.SendPropertyChanged(nameof (PR_NAMEENG));
      }
    }

    [Column(Storage = "_PR_BOSSNAME", DbType = "VarChar(40)", UpdateCheck = UpdateCheck.Never)]
    public string PR_BOSSNAME
    {
      get => this._PR_BOSSNAME;
      set
      {
        if (!(this._PR_BOSSNAME != value))
          return;
        this.SendPropertyChanging();
        this._PR_BOSSNAME = value;
        this.SendPropertyChanged(nameof (PR_BOSSNAME));
      }
    }

    [Column(Storage = "_PR_BOSS", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_BOSS
    {
      get => this._PR_BOSS;
      set
      {
        if (!(this._PR_BOSS != value))
          return;
        this.SendPropertyChanging();
        this._PR_BOSS = value;
        this.SendPropertyChanged(nameof (PR_BOSS));
      }
    }

    [Column(Storage = "_PR_MALE", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? PR_MALE
    {
      get => this._PR_MALE;
      set
      {
        short? prMale = this._PR_MALE;
        short? nullable = value;
        if (((int) prMale.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (prMale.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_MALE = value;
        this.SendPropertyChanged(nameof (PR_MALE));
      }
    }

    [Column(Storage = "_PR_MAINMEN", DbType = "VarChar(45)", UpdateCheck = UpdateCheck.Never)]
    public string PR_MAINMEN
    {
      get => this._PR_MAINMEN;
      set
      {
        if (!(this._PR_MAINMEN != value))
          return;
        this.SendPropertyChanging();
        this._PR_MAINMEN = value;
        this.SendPropertyChanged(nameof (PR_MAINMEN));
      }
    }

    [Column(Storage = "_PR_MAINMENPHONE", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_MAINMENPHONE
    {
      get => this._PR_MAINMENPHONE;
      set
      {
        if (!(this._PR_MAINMENPHONE != value))
          return;
        this.SendPropertyChanging();
        this._PR_MAINMENPHONE = value;
        this.SendPropertyChanged(nameof (PR_MAINMENPHONE));
      }
    }

    [Column(Storage = "_PR_DISCOUNT", DbType = "Float", UpdateCheck = UpdateCheck.Never)]
    public double? PR_DISCOUNT
    {
      get => this._PR_DISCOUNT;
      set
      {
        double? prDiscount = this._PR_DISCOUNT;
        double? nullable = value;
        if ((prDiscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prDiscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_DISCOUNT = value;
        this.SendPropertyChanged(nameof (PR_DISCOUNT));
      }
    }

    [Column(Storage = "_PR_ACCOUNT", DbType = "VarChar(200)", UpdateCheck = UpdateCheck.Never)]
    public string PR_ACCOUNT
    {
      get => this._PR_ACCOUNT;
      set
      {
        if (!(this._PR_ACCOUNT != value))
          return;
        this.SendPropertyChanging();
        this._PR_ACCOUNT = value;
        this.SendPropertyChanged(nameof (PR_ACCOUNT));
      }
    }

    [Column(Storage = "_PR_ADRESS", DbType = "VarChar(330)", UpdateCheck = UpdateCheck.Never)]
    public string PR_ADRESS
    {
      get => this._PR_ADRESS;
      set
      {
        if (!(this._PR_ADRESS != value))
          return;
        this.SendPropertyChanging();
        this._PR_ADRESS = value;
        this.SendPropertyChanged(nameof (PR_ADRESS));
      }
    }

    [Column(Storage = "_PR_PHONES", DbType = "VarChar(254)", UpdateCheck = UpdateCheck.Never)]
    public string PR_PHONES
    {
      get => this._PR_PHONES;
      set
      {
        if (!(this._PR_PHONES != value))
          return;
        this.SendPropertyChanging();
        this._PR_PHONES = value;
        this.SendPropertyChanged(nameof (PR_PHONES));
      }
    }

    [Column(Storage = "_PR_FAX", DbType = "VarChar(120)", UpdateCheck = UpdateCheck.Never)]
    public string PR_FAX
    {
      get => this._PR_FAX;
      set
      {
        if (!(this._PR_FAX != value))
          return;
        this.SendPropertyChanging();
        this._PR_FAX = value;
        this.SendPropertyChanged(nameof (PR_FAX));
      }
    }

    [Column(Storage = "_PR_EMAIL", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_EMAIL
    {
      get => this._PR_EMAIL;
      set
      {
        if (!(this._PR_EMAIL != value))
          return;
        this.SendPropertyChanging();
        this._PR_EMAIL = value;
        this.SendPropertyChanged(nameof (PR_EMAIL));
      }
    }

    [Column(Storage = "_PR_CTKEY", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? PR_CTKEY
    {
      get => this._PR_CTKEY;
      set
      {
        int? prCtkey = this._PR_CTKEY;
        int? nullable = value;
        if ((prCtkey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prCtkey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        if (this._CityDictionary.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._PR_CTKEY = value;
        this.SendPropertyChanged(nameof (PR_CTKEY));
      }
    }

    [Column(Storage = "_PR_CREATOR", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int PR_CREATOR
    {
      get => this._PR_CREATOR;
      set
      {
        if (this._PR_CREATOR == value)
          return;
        this.SendPropertyChanging();
        this._PR_CREATOR = value;
        this.SendPropertyChanged(nameof (PR_CREATOR));
      }
    }

    [Column(Storage = "_PR_AGENTDOGOVOR", DbType = "VarChar(12)", UpdateCheck = UpdateCheck.Never)]
    public string PR_AGENTDOGOVOR
    {
      get => this._PR_AGENTDOGOVOR;
      set
      {
        if (!(this._PR_AGENTDOGOVOR != value))
          return;
        this.SendPropertyChanging();
        this._PR_AGENTDOGOVOR = value;
        this.SendPropertyChanged(nameof (PR_AGENTDOGOVOR));
      }
    }

    [Column(Storage = "_PR_TYPE", DbType = "BigInt", UpdateCheck = UpdateCheck.Never)]
    public long? PR_TYPE
    {
      get => this._PR_TYPE;
      set
      {
        long? prType = this._PR_TYPE;
        long? nullable = value;
        if ((prType.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prType.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_TYPE = value;
        this.SendPropertyChanged(nameof (PR_TYPE));
      }
    }

    [Column(Storage = "_PR_CITY", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_CITY
    {
      get => this._PR_CITY;
      set
      {
        if (!(this._PR_CITY != value))
          return;
        this.SendPropertyChanging();
        this._PR_CITY = value;
        this.SendPropertyChanged(nameof (PR_CITY));
      }
    }

    [Column(Storage = "_PR_WEBAGENT", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? PR_WEBAGENT
    {
      get => this._PR_WEBAGENT;
      set
      {
        int? prWebagent = this._PR_WEBAGENT;
        int? nullable = value;
        if ((prWebagent.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prWebagent.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_WEBAGENT = value;
        this.SendPropertyChanged(nameof (PR_WEBAGENT));
      }
    }

    [Column(Storage = "_PR_AGENTDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? PR_AGENTDATE
    {
      get => this._PR_AGENTDATE;
      set
      {
        DateTime? prAgentdate = this._PR_AGENTDATE;
        DateTime? nullable = value;
        if ((prAgentdate.HasValue != nullable.HasValue ? 1 : (!prAgentdate.HasValue ? 0 : (prAgentdate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_AGENTDATE = value;
        this.SendPropertyChanged(nameof (PR_AGENTDATE));
      }
    }

    [Column(Storage = "_PR_AGENTDOGOVOR2", DbType = "VarChar(12)", UpdateCheck = UpdateCheck.Never)]
    public string PR_AGENTDOGOVOR2
    {
      get => this._PR_AGENTDOGOVOR2;
      set
      {
        if (!(this._PR_AGENTDOGOVOR2 != value))
          return;
        this.SendPropertyChanging();
        this._PR_AGENTDOGOVOR2 = value;
        this.SendPropertyChanged(nameof (PR_AGENTDOGOVOR2));
      }
    }

    [Column(Storage = "_PR_AGENTDATE2", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? PR_AGENTDATE2
    {
      get => this._PR_AGENTDATE2;
      set
      {
        DateTime? prAgentdatE2 = this._PR_AGENTDATE2;
        DateTime? nullable = value;
        if ((prAgentdatE2.HasValue != nullable.HasValue ? 1 : (!prAgentdatE2.HasValue ? 0 : (prAgentdatE2.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_AGENTDATE2 = value;
        this.SendPropertyChanged(nameof (PR_AGENTDATE2));
      }
    }

    [Column(Storage = "_PR_FAX1", DbType = "VarChar(20)", UpdateCheck = UpdateCheck.Never)]
    public string PR_FAX1
    {
      get => this._PR_FAX1;
      set
      {
        if (!(this._PR_FAX1 != value))
          return;
        this.SendPropertyChanging();
        this._PR_FAX1 = value;
        this.SendPropertyChanged(nameof (PR_FAX1));
      }
    }

    [Column(Storage = "_PR_REMARK", DbType = "VarChar(254)", UpdateCheck = UpdateCheck.Never)]
    public string PR_REMARK
    {
      get => this._PR_REMARK;
      set
      {
        if (!(this._PR_REMARK != value))
          return;
        this.SendPropertyChanging();
        this._PR_REMARK = value;
        this.SendPropertyChanged(nameof (PR_REMARK));
      }
    }

    [Column(Storage = "_PR_CREATEDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? PR_CREATEDATE
    {
      get => this._PR_CREATEDATE;
      set
      {
        DateTime? prCreatedate = this._PR_CREATEDATE;
        DateTime? nullable = value;
        if ((prCreatedate.HasValue != nullable.HasValue ? 1 : (!prCreatedate.HasValue ? 0 : (prCreatedate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_CREATEDATE = value;
        this.SendPropertyChanged(nameof (PR_CREATEDATE));
      }
    }

    [Column(Storage = "_PR_UPDATEDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? PR_UPDATEDATE
    {
      get => this._PR_UPDATEDATE;
      set
      {
        DateTime? prUpdatedate = this._PR_UPDATEDATE;
        DateTime? nullable = value;
        if ((prUpdatedate.HasValue != nullable.HasValue ? 1 : (!prUpdatedate.HasValue ? 0 : (prUpdatedate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_UPDATEDATE = value;
        this.SendPropertyChanged(nameof (PR_UPDATEDATE));
      }
    }

    [Column(Storage = "_PR_ART", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? PR_ART
    {
      get => this._PR_ART;
      set
      {
        int? prArt = this._PR_ART;
        int? nullable = value;
        if ((prArt.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prArt.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_ART = value;
        this.SendPropertyChanged(nameof (PR_ART));
      }
    }

    [Column(Storage = "_PR_USERLAST", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? PR_USERLAST
    {
      get => this._PR_USERLAST;
      set
      {
        int? prUserlast = this._PR_USERLAST;
        int? nullable = value;
        if ((prUserlast.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prUserlast.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_USERLAST = value;
        this.SendPropertyChanged(nameof (PR_USERLAST));
      }
    }

    [Column(Storage = "_PR_COD", DbType = "VarChar(6)", UpdateCheck = UpdateCheck.Never)]
    public string PR_COD
    {
      get => this._PR_COD;
      set
      {
        if (!(this._PR_COD != value))
          return;
        this.SendPropertyChanging();
        this._PR_COD = value;
        this.SendPropertyChanged(nameof (PR_COD));
      }
    }

    [Column(Storage = "_ROWID", AutoSync = AutoSync.Always, DbType = "rowversion NOT NULL", CanBeNull = false, IsDbGenerated = true, IsVersion = true, UpdateCheck = UpdateCheck.Never)]
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

    [Column(Storage = "_PR_Filial", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int PR_Filial
    {
      get => this._PR_Filial;
      set
      {
        if (this._PR_Filial == value)
          return;
        this.SendPropertyChanging();
        this._PR_Filial = value;
        this.SendPropertyChanged(nameof (PR_Filial));
      }
    }

    [Column(Storage = "_PR_DateLastContact", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? PR_DateLastContact
    {
      get => this._PR_DateLastContact;
      set
      {
        DateTime? prDateLastContact = this._PR_DateLastContact;
        DateTime? nullable = value;
        if ((prDateLastContact.HasValue != nullable.HasValue ? 1 : (!prDateLastContact.HasValue ? 0 : (prDateLastContact.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_DateLastContact = value;
        this.SendPropertyChanged(nameof (PR_DateLastContact));
      }
    }

    [Column(Storage = "_PR_ExchangePwd", DbType = "VarChar(20)", UpdateCheck = UpdateCheck.Never)]
    public string PR_ExchangePwd
    {
      get => this._PR_ExchangePwd;
      set
      {
        if (!(this._PR_ExchangePwd != value))
          return;
        this.SendPropertyChanging();
        this._PR_ExchangePwd = value;
        this.SendPropertyChanged(nameof (PR_ExchangePwd));
      }
    }

    [Column(Storage = "_PR_GUID", DbType = "VarChar(40)", UpdateCheck = UpdateCheck.Never)]
    public string PR_GUID
    {
      get => this._PR_GUID;
      set
      {
        if (!(this._PR_GUID != value))
          return;
        this.SendPropertyChanging();
        this._PR_GUID = value;
        this.SendPropertyChanged(nameof (PR_GUID));
      }
    }

    [Column(Storage = "_PR_ExchangeData", DbType = "Binary(50)", UpdateCheck = UpdateCheck.Never)]
    public Binary PR_ExchangeData
    {
      get => this._PR_ExchangeData;
      set
      {
        if (!(this._PR_ExchangeData != value))
          return;
        this.SendPropertyChanging();
        this._PR_ExchangeData = value;
        this.SendPropertyChanged(nameof (PR_ExchangeData));
      }
    }

    [Column(Storage = "_PR_DOGOVORTYPE", DbType = "SmallInt NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public short PR_DOGOVORTYPE
    {
      get => this._PR_DOGOVORTYPE;
      set
      {
        if ((int) this._PR_DOGOVORTYPE == (int) value)
          return;
        this.SendPropertyChanging();
        this._PR_DOGOVORTYPE = value;
        this.SendPropertyChanged(nameof (PR_DOGOVORTYPE));
      }
    }

    [Column(Storage = "_PR_ICQ", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_ICQ
    {
      get => this._PR_ICQ;
      set
      {
        if (!(this._PR_ICQ != value))
          return;
        this.SendPropertyChanging();
        this._PR_ICQ = value;
        this.SendPropertyChanged(nameof (PR_ICQ));
      }
    }

    [Column(Storage = "_PR_GDS_PREFIX", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_GDS_PREFIX
    {
      get => this._PR_GDS_PREFIX;
      set
      {
        if (!(this._PR_GDS_PREFIX != value))
          return;
        this.SendPropertyChanging();
        this._PR_GDS_PREFIX = value;
        this.SendPropertyChanged(nameof (PR_GDS_PREFIX));
      }
    }

    [Column(Storage = "_PR_GDS_SUFFIX", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_GDS_SUFFIX
    {
      get => this._PR_GDS_SUFFIX;
      set
      {
        if (!(this._PR_GDS_SUFFIX != value))
          return;
        this.SendPropertyChanging();
        this._PR_GDS_SUFFIX = value;
        this.SendPropertyChanged(nameof (PR_GDS_SUFFIX));
      }
    }

    [Column(Storage = "_PR_OWNER", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? PR_OWNER
    {
      get => this._PR_OWNER;
      set
      {
        int? prOwner = this._PR_OWNER;
        int? nullable = value;
        if ((prOwner.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prOwner.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PR_OWNER = value;
        this.SendPropertyChanged(nameof (PR_OWNER));
      }
    }

    [Column(Storage = "_PR_IPAddress", DbType = "VarChar(80)", UpdateCheck = UpdateCheck.Never)]
    public string PR_IPAddress
    {
      get => this._PR_IPAddress;
      set
      {
        if (!(this._PR_IPAddress != value))
          return;
        this.SendPropertyChanging();
        this._PR_IPAddress = value;
        this.SendPropertyChanged(nameof (PR_IPAddress));
      }
    }

    [Column(Storage = "_PR_Description", DbType = "Text", UpdateCheck = UpdateCheck.Never)]
    public string PR_Description
    {
      get => this._PR_Description;
      set
      {
        if (!(this._PR_Description != value))
          return;
        this.SendPropertyChanging();
        this._PR_Description = value;
        this.SendPropertyChanged(nameof (PR_Description));
      }
    }

    [Column(Storage = "_PR_Deleted", DbType = "SmallInt NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public short PR_Deleted
    {
      get => this._PR_Deleted;
      set
      {
        if ((int) this._PR_Deleted == (int) value)
          return;
        this.SendPropertyChanging();
        this._PR_Deleted = value;
        this.SendPropertyChanged(nameof (PR_Deleted));
      }
    }

    [Column(Storage = "_PR_LICENSENUMBER", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_LICENSENUMBER
    {
      get => this._PR_LICENSENUMBER;
      set
      {
        if (!(this._PR_LICENSENUMBER != value))
          return;
        this.SendPropertyChanging();
        this._PR_LICENSENUMBER = value;
        this.SendPropertyChanged(nameof (PR_LICENSENUMBER));
      }
    }

    [Column(Storage = "_PR_ADDITIONALINFO", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_ADDITIONALINFO
    {
      get => this._PR_ADDITIONALINFO;
      set
      {
        if (!(this._PR_ADDITIONALINFO != value))
          return;
        this.SendPropertyChanging();
        this._PR_ADDITIONALINFO = value;
        this.SendPropertyChanged(nameof (PR_ADDITIONALINFO));
      }
    }

    [Column(Storage = "_PR_LEGALADDRESS", DbType = "VarChar(350)", UpdateCheck = UpdateCheck.Never)]
    public string PR_LEGALADDRESS
    {
      get => this._PR_LEGALADDRESS;
      set
      {
        if (!(this._PR_LEGALADDRESS != value))
          return;
        this.SendPropertyChanging();
        this._PR_LEGALADDRESS = value;
        this.SendPropertyChanged(nameof (PR_LEGALADDRESS));
      }
    }

    [Column(Storage = "_PR_INN", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_INN
    {
      get => this._PR_INN;
      set
      {
        if (!(this._PR_INN != value))
          return;
        this.SendPropertyChanging();
        this._PR_INN = value;
        this.SendPropertyChanged(nameof (PR_INN));
      }
    }

    [Column(Storage = "_PR_FOREIGNACCINFO", DbType = "VarChar(30)", UpdateCheck = UpdateCheck.Never)]
    public string PR_FOREIGNACCINFO
    {
      get => this._PR_FOREIGNACCINFO;
      set
      {
        if (!(this._PR_FOREIGNACCINFO != value))
          return;
        this.SendPropertyChanging();
        this._PR_FOREIGNACCINFO = value;
        this.SendPropertyChanged(nameof (PR_FOREIGNACCINFO));
      }
    }

    [Column(Storage = "_PR_KPP", DbType = "VarChar(30)", UpdateCheck = UpdateCheck.Never)]
    public string PR_KPP
    {
      get => this._PR_KPP;
      set
      {
        if (!(this._PR_KPP != value))
          return;
        this.SendPropertyChanging();
        this._PR_KPP = value;
        this.SendPropertyChanged(nameof (PR_KPP));
      }
    }

    [Column(Storage = "_PR_CODEOKONH", DbType = "VarChar(30)", UpdateCheck = UpdateCheck.Never)]
    public string PR_CODEOKONH
    {
      get => this._PR_CODEOKONH;
      set
      {
        if (!(this._PR_CODEOKONH != value))
          return;
        this.SendPropertyChanging();
        this._PR_CODEOKONH = value;
        this.SendPropertyChanged(nameof (PR_CODEOKONH));
      }
    }

    [Column(Storage = "_PR_CODEOKPO", DbType = "VarChar(30)", UpdateCheck = UpdateCheck.Never)]
    public string PR_CODEOKPO
    {
      get => this._PR_CODEOKPO;
      set
      {
        if (!(this._PR_CODEOKPO != value))
          return;
        this.SendPropertyChanging();
        this._PR_CODEOKPO = value;
        this.SendPropertyChanged(nameof (PR_CODEOKPO));
      }
    }

    [Column(Storage = "_PR_HOMEPAGE", DbType = "VarChar(100)", UpdateCheck = UpdateCheck.Never)]
    public string PR_HOMEPAGE
    {
      get => this._PR_HOMEPAGE;
      set
      {
        if (!(this._PR_HOMEPAGE != value))
          return;
        this.SendPropertyChanging();
        this._PR_HOMEPAGE = value;
        this.SendPropertyChanged(nameof (PR_HOMEPAGE));
      }
    }

    [Column(Storage = "_PR_PGKEY", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int PR_PGKEY
    {
      get => this._PR_PGKEY;
      set
      {
        if (this._PR_PGKEY == value)
          return;
        this.SendPropertyChanging();
        this._PR_PGKEY = value;
        this.SendPropertyChanged(nameof (PR_PGKEY));
      }
    }

    [Column(Storage = "_PR_BLOCKEDFORANNUL", DbType = "SmallInt NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public short PR_BLOCKEDFORANNUL
    {
      get => this._PR_BLOCKEDFORANNUL;
      set
      {
        if ((int) this._PR_BLOCKEDFORANNUL == (int) value)
          return;
        this.SendPropertyChanging();
        this._PR_BLOCKEDFORANNUL = value;
        this.SendPropertyChanged(nameof (PR_BLOCKEDFORANNUL));
      }
    }

    [Column(Storage = "_PR_POSTINDEX", DbType = "VarChar(6)", UpdateCheck = UpdateCheck.Never)]
    public string PR_POSTINDEX
    {
      get => this._PR_POSTINDEX;
      set
      {
        if (!(this._PR_POSTINDEX != value))
          return;
        this.SendPropertyChanging();
        this._PR_POSTINDEX = value;
        this.SendPropertyChanged(nameof (PR_POSTINDEX));
      }
    }

    [Column(Storage = "_PR_LEGALPOSTINDEX", DbType = "VarChar(6)", UpdateCheck = UpdateCheck.Never)]
    public string PR_LEGALPOSTINDEX
    {
      get => this._PR_LEGALPOSTINDEX;
      set
      {
        if (!(this._PR_LEGALPOSTINDEX != value))
          return;
        this.SendPropertyChanging();
        this._PR_LEGALPOSTINDEX = value;
        this.SendPropertyChanged(nameof (PR_LEGALPOSTINDEX));
      }
    }

    [Column(Storage = "_PR_RegisterSeries", DbType = "VarChar(10)", UpdateCheck = UpdateCheck.Never)]
    public string PR_RegisterSeries
    {
      get => this._PR_RegisterSeries;
      set
      {
        if (!(this._PR_RegisterSeries != value))
          return;
        this.SendPropertyChanging();
        this._PR_RegisterSeries = value;
        this.SendPropertyChanged(nameof (PR_RegisterSeries));
      }
    }

    [Column(Storage = "_PR_RegisterNumber", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string PR_RegisterNumber
    {
      get => this._PR_RegisterNumber;
      set
      {
        if (!(this._PR_RegisterNumber != value))
          return;
        this.SendPropertyChanging();
        this._PR_RegisterNumber = value;
        this.SendPropertyChanged(nameof (PR_RegisterNumber));
      }
    }

    [Column(Storage = "_PR_WebServiceUrl", DbType = "VarChar(150)", UpdateCheck = UpdateCheck.Never)]
    public string PR_WebServiceUrl
    {
      get => this._PR_WebServiceUrl;
      set
      {
        if (!(this._PR_WebServiceUrl != value))
          return;
        this.SendPropertyChanging();
        this._PR_WebServiceUrl = value;
        this.SendPropertyChanged(nameof (PR_WebServiceUrl));
      }
    }

    [Column(Storage = "_PR_PrivatePerson", DbType = "Bit NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public bool PR_PrivatePerson
    {
      get => this._PR_PrivatePerson;
      set
      {
        if (this._PR_PrivatePerson == value)
          return;
        this.SendPropertyChanging();
        this._PR_PrivatePerson = value;
        this.SendPropertyChanged(nameof (PR_PrivatePerson));
      }
    }

    [Association(Name = "tbl_Partner_tbl_Dogovor", Storage = "_tbl_Dogovors", ThisKey = "PR_KEY", OtherKey = "DG_FilialKey")]
    public EntitySet<tbl_Dogovor> tbl_Dogovors
    {
      get => this._tbl_Dogovors;
      set => this._tbl_Dogovors.Assign((IEnumerable<tbl_Dogovor>) value);
    }

    [Association(Name = "tbl_Partner_PrtTypesToPartner", Storage = "_PrtTypesToPartners", ThisKey = "PR_KEY", OtherKey = "PTP_PRKey")]
    public EntitySet<PrtTypesToPartner> PrtTypesToPartners
    {
      get => this._PrtTypesToPartners;
      set => this._PrtTypesToPartners.Assign((IEnumerable<PrtTypesToPartner>) value);
    }

    [Association(Name = "CityDictionary_tbl_Partner", Storage = "_CityDictionary", ThisKey = "PR_CTKEY", OtherKey = "CT_KEY", IsForeignKey = true)]
    public CityDictionary CityDictionary
    {
      get => this._CityDictionary.Entity;
      set
      {
        CityDictionary entity = this._CityDictionary.Entity;
        if (entity == value && this._CityDictionary.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._CityDictionary.Entity = (CityDictionary) null;
          entity.tbl_Partners.Remove(this);
        }
        this._CityDictionary.Entity = value;
        if (value != null)
        {
          value.tbl_Partners.Add(this);
          this._PR_CTKEY = new int?(value.CT_KEY);
        }
        else
          this._PR_CTKEY = new int?();
        this.SendPropertyChanged(nameof (CityDictionary));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tbl_Partner.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void attach_tbl_Dogovors(tbl_Dogovor entity)
    {
      this.SendPropertyChanging();
      entity.tbl_Partner = this;
    }

    private void detach_tbl_Dogovors(tbl_Dogovor entity)
    {
      this.SendPropertyChanging();
      entity.tbl_Partner = (tbl_Partner) null;
    }

    private void attach_PrtTypesToPartners(PrtTypesToPartner entity)
    {
      this.SendPropertyChanging();
      entity.tbl_Partner = this;
    }

    private void detach_PrtTypesToPartners(PrtTypesToPartner entity)
    {
      this.SendPropertyChanging();
      entity.tbl_Partner = (tbl_Partner) null;
    }
  }
}
