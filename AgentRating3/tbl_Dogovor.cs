// Decompiled with JetBrains decompiler
// Type: AgentRating3.tbl_Dogovor
// Assembly: AgentRating, Version=3.5.1.0, Culture=neutral, PublicKeyToken=null
// MVID: F060002B-D351-46BE-ABE3-10F01194E01C
// Assembly location: D:\MyProject\AgentRating\bin\Release\AgentRating.exe

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AgentRating3
{
  [Table(Name = "dbo.tbl_Dogovor")]
  public class tbl_Dogovor : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private string _DG_CODE;
    private DateTime _DG_TURDATE;
    private int? _DG_TRKEY;
    private int _DG_CNKEY;
    private int _DG_CTKEY;
    private short? _DG_NMEN;
    private Decimal _DG_PRICE;
    private Decimal? _DG_PAYED;
    private double _DG_NDAY;
    private string _DG_MAINMEN;
    private string _DG_MAINMENPHONE;
    private string _DG_MAINMENADRESS;
    private string _DG_MAINMENPASPORT;
    private int? _DG_PARTNERKEY;
    private string _DG_OPERATOR;
    private short? _DG_PRINTDOGOVOR;
    private short? _DG_PRINTVAUCHER;
    private short? _DG_TYPECOUNT;
    private Decimal? _DG_DISCOUNT;
    private Decimal _DG_DISCOUNTSUM;
    private int _DG_CREATOR;
    private int _DG_OWNER;
    private int _DG_SOR_CODE;
    private DateTime _DG_CRDATE;
    private string _DG_RATE;
    private int? _DG_ADVERTISE;
    private short? _DG_LOCKED;
    private int? _DG_CAUSEDISC;
    private DateTime? _DG_VISADATE;
    private DateTime? _DG_PPAYMENTDATE;
    private DateTime? _DG_PAYMENTDATE;
    private DateTime? _DG_TURPUTDATE;
    private string _DG_DOCUMENT;
    private string _DG_TURPUTPLACE;
    private int? _DG_PROCENT;
    private DateTime? _DG_OLDTOURDATE;
    private Binary _ROWID;
    private DateTime? _DG_TurDateBfrAnnul;
    private int? _DG_ARKey;
    private int _DG_Key;
    private string _DG_CodePartner;
    private int _DG_FilialKey;
    private int _DG_IsOutDoc;
    private int? _DG_AgentID;
    private short? _DG_TRANSFERRED;
    private string _DG_NOTES;
    private double? _DG_INVOICECOST;
    private int? _DG_DCRCLIENT;
    private int? _DG_DCRPAYMENT;
    private int? _DG_ISMAKEDISCOUNT;
    private Decimal? _DG_DISCSUMBFRANN;
    private Decimal? _DG_PRICEBFRANN;
    private Decimal? _DG_RazmerP;
    private int _DG_LEADDEPARTMENT;
    private string _DG_MAINMENEMAIL;
    private string _DG_MAINMENCOMMENT;
    private int? _DG_DUPUSERKEY;
    private int? _DG_BTKEY;
    private DateTime? _DG_ConfirmedDate;
    private int _DG_PRTDOGKEY;
    private int? _DG_CTDepartureKey;
    private Decimal? _DG_SalePrice;
    private Decimal? _DG_SaleDiscount;
    private short _DG_PDTType;
    private Decimal? _DG_NATIONALCURRENCYPRICE;
    private Decimal? _DG_NATIONALCURRENCYDISCOUNTSUM;
    private int? _DG_DAKey;
    private Decimal? _DG_NATIONALCURRENCYPAYED;
    private int? _DG_CurrencyKey;
    private Decimal? _DG_CurrencyRate;
    private byte? _DG_ProTourFlag;
    private EntityRef<tbl_Partner> _tbl_Partner;

    public tbl_Dogovor() => this._tbl_Partner = new EntityRef<tbl_Partner>();

    [Column(Storage = "_DG_CODE", DbType = "VarChar(10) NOT NULL", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string DG_CODE
    {
      get => this._DG_CODE;
      set
      {
        if (!(this._DG_CODE != value))
          return;
        this.SendPropertyChanging();
        this._DG_CODE = value;
        this.SendPropertyChanged(nameof (DG_CODE));
      }
    }

    [Column(Storage = "_DG_TURDATE", DbType = "DateTime NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public DateTime DG_TURDATE
    {
      get => this._DG_TURDATE;
      set
      {
        if (!(this._DG_TURDATE != value))
          return;
        this.SendPropertyChanging();
        this._DG_TURDATE = value;
        this.SendPropertyChanged(nameof (DG_TURDATE));
      }
    }

    [Column(Storage = "_DG_TRKEY", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_TRKEY
    {
      get => this._DG_TRKEY;
      set
      {
        int? dgTrkey = this._DG_TRKEY;
        int? nullable = value;
        if ((dgTrkey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgTrkey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_TRKEY = value;
        this.SendPropertyChanged(nameof (DG_TRKEY));
      }
    }

    [Column(Storage = "_DG_CNKEY", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_CNKEY
    {
      get => this._DG_CNKEY;
      set
      {
        if (this._DG_CNKEY == value)
          return;
        this.SendPropertyChanging();
        this._DG_CNKEY = value;
        this.SendPropertyChanged(nameof (DG_CNKEY));
      }
    }

    [Column(Storage = "_DG_CTKEY", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_CTKEY
    {
      get => this._DG_CTKEY;
      set
      {
        if (this._DG_CTKEY == value)
          return;
        this.SendPropertyChanging();
        this._DG_CTKEY = value;
        this.SendPropertyChanged(nameof (DG_CTKEY));
      }
    }

    [Column(Storage = "_DG_NMEN", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_NMEN
    {
      get => this._DG_NMEN;
      set
      {
        short? dgNmen = this._DG_NMEN;
        short? nullable = value;
        if (((int) dgNmen.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgNmen.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_NMEN = value;
        this.SendPropertyChanged(nameof (DG_NMEN));
      }
    }

    [Column(Storage = "_DG_PRICE", DbType = "Money NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public Decimal DG_PRICE
    {
      get => this._DG_PRICE;
      set
      {
        if (!(this._DG_PRICE != value))
          return;
        this.SendPropertyChanging();
        this._DG_PRICE = value;
        this.SendPropertyChanged(nameof (DG_PRICE));
      }
    }

    [Column(Storage = "_DG_PAYED", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_PAYED
    {
      get => this._DG_PAYED;
      set
      {
        Decimal? dgPayed = this._DG_PAYED;
        Decimal? nullable = value;
        if ((dgPayed.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgPayed.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PAYED = value;
        this.SendPropertyChanged(nameof (DG_PAYED));
      }
    }

    [Column(Storage = "_DG_NDAY", DbType = "Float NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public double DG_NDAY
    {
      get => this._DG_NDAY;
      set
      {
        if (this._DG_NDAY == value)
          return;
        this.SendPropertyChanging();
        this._DG_NDAY = value;
        this.SendPropertyChanged(nameof (DG_NDAY));
      }
    }

    [Column(Storage = "_DG_MAINMEN", DbType = "VarChar(70)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMEN
    {
      get => this._DG_MAINMEN;
      set
      {
        if (!(this._DG_MAINMEN != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMEN = value;
        this.SendPropertyChanged(nameof (DG_MAINMEN));
      }
    }

    [Column(Storage = "_DG_MAINMENPHONE", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMENPHONE
    {
      get => this._DG_MAINMENPHONE;
      set
      {
        if (!(this._DG_MAINMENPHONE != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMENPHONE = value;
        this.SendPropertyChanged(nameof (DG_MAINMENPHONE));
      }
    }

    [Column(Storage = "_DG_MAINMENADRESS", DbType = "VarChar(320)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMENADRESS
    {
      get => this._DG_MAINMENADRESS;
      set
      {
        if (!(this._DG_MAINMENADRESS != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMENADRESS = value;
        this.SendPropertyChanged(nameof (DG_MAINMENADRESS));
      }
    }

    [Column(Storage = "_DG_MAINMENPASPORT", DbType = "VarChar(70)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMENPASPORT
    {
      get => this._DG_MAINMENPASPORT;
      set
      {
        if (!(this._DG_MAINMENPASPORT != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMENPASPORT = value;
        this.SendPropertyChanged(nameof (DG_MAINMENPASPORT));
      }
    }

    [Column(Storage = "_DG_PARTNERKEY", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_PARTNERKEY
    {
      get => this._DG_PARTNERKEY;
      set
      {
        int? dgPartnerkey = this._DG_PARTNERKEY;
        int? nullable = value;
        if ((dgPartnerkey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgPartnerkey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PARTNERKEY = value;
        this.SendPropertyChanged(nameof (DG_PARTNERKEY));
      }
    }

    [Column(Storage = "_DG_OPERATOR", DbType = "VarChar(25)", UpdateCheck = UpdateCheck.Never)]
    public string DG_OPERATOR
    {
      get => this._DG_OPERATOR;
      set
      {
        if (!(this._DG_OPERATOR != value))
          return;
        this.SendPropertyChanging();
        this._DG_OPERATOR = value;
        this.SendPropertyChanged(nameof (DG_OPERATOR));
      }
    }

    [Column(Storage = "_DG_PRINTDOGOVOR", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_PRINTDOGOVOR
    {
      get => this._DG_PRINTDOGOVOR;
      set
      {
        short? dgPrintdogovor = this._DG_PRINTDOGOVOR;
        short? nullable = value;
        if (((int) dgPrintdogovor.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgPrintdogovor.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PRINTDOGOVOR = value;
        this.SendPropertyChanged(nameof (DG_PRINTDOGOVOR));
      }
    }

    [Column(Storage = "_DG_PRINTVAUCHER", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_PRINTVAUCHER
    {
      get => this._DG_PRINTVAUCHER;
      set
      {
        short? dgPrintvaucher = this._DG_PRINTVAUCHER;
        short? nullable = value;
        if (((int) dgPrintvaucher.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgPrintvaucher.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PRINTVAUCHER = value;
        this.SendPropertyChanged(nameof (DG_PRINTVAUCHER));
      }
    }

    [Column(Storage = "_DG_TYPECOUNT", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_TYPECOUNT
    {
      get => this._DG_TYPECOUNT;
      set
      {
        short? dgTypecount = this._DG_TYPECOUNT;
        short? nullable = value;
        if (((int) dgTypecount.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgTypecount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_TYPECOUNT = value;
        this.SendPropertyChanged(nameof (DG_TYPECOUNT));
      }
    }

    [Column(Storage = "_DG_DISCOUNT", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_DISCOUNT
    {
      get => this._DG_DISCOUNT;
      set
      {
        Decimal? dgDiscount = this._DG_DISCOUNT;
        Decimal? nullable = value;
        if ((dgDiscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDiscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DISCOUNT = value;
        this.SendPropertyChanged(nameof (DG_DISCOUNT));
      }
    }

    [Column(Storage = "_DG_DISCOUNTSUM", DbType = "Money NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public Decimal DG_DISCOUNTSUM
    {
      get => this._DG_DISCOUNTSUM;
      set
      {
        if (!(this._DG_DISCOUNTSUM != value))
          return;
        this.SendPropertyChanging();
        this._DG_DISCOUNTSUM = value;
        this.SendPropertyChanged(nameof (DG_DISCOUNTSUM));
      }
    }

    [Column(Storage = "_DG_CREATOR", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_CREATOR
    {
      get => this._DG_CREATOR;
      set
      {
        if (this._DG_CREATOR == value)
          return;
        this.SendPropertyChanging();
        this._DG_CREATOR = value;
        this.SendPropertyChanged(nameof (DG_CREATOR));
      }
    }

    [Column(Storage = "_DG_OWNER", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_OWNER
    {
      get => this._DG_OWNER;
      set
      {
        if (this._DG_OWNER == value)
          return;
        this.SendPropertyChanging();
        this._DG_OWNER = value;
        this.SendPropertyChanged(nameof (DG_OWNER));
      }
    }

    [Column(Storage = "_DG_SOR_CODE", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_SOR_CODE
    {
      get => this._DG_SOR_CODE;
      set
      {
        if (this._DG_SOR_CODE == value)
          return;
        this.SendPropertyChanging();
        this._DG_SOR_CODE = value;
        this.SendPropertyChanged(nameof (DG_SOR_CODE));
      }
    }

    [Column(Storage = "_DG_CRDATE", DbType = "DateTime NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public DateTime DG_CRDATE
    {
      get => this._DG_CRDATE;
      set
      {
        if (!(this._DG_CRDATE != value))
          return;
        this.SendPropertyChanging();
        this._DG_CRDATE = value;
        this.SendPropertyChanged(nameof (DG_CRDATE));
      }
    }

    [Column(Storage = "_DG_RATE", DbType = "VarChar(3)", UpdateCheck = UpdateCheck.Never)]
    public string DG_RATE
    {
      get => this._DG_RATE;
      set
      {
        if (!(this._DG_RATE != value))
          return;
        this.SendPropertyChanging();
        this._DG_RATE = value;
        this.SendPropertyChanged(nameof (DG_RATE));
      }
    }

    [Column(Storage = "_DG_ADVERTISE", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_ADVERTISE
    {
      get => this._DG_ADVERTISE;
      set
      {
        int? dgAdvertise = this._DG_ADVERTISE;
        int? nullable = value;
        if ((dgAdvertise.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgAdvertise.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_ADVERTISE = value;
        this.SendPropertyChanged(nameof (DG_ADVERTISE));
      }
    }

    [Column(Storage = "_DG_LOCKED", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_LOCKED
    {
      get => this._DG_LOCKED;
      set
      {
        short? dgLocked = this._DG_LOCKED;
        short? nullable = value;
        if (((int) dgLocked.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgLocked.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_LOCKED = value;
        this.SendPropertyChanged(nameof (DG_LOCKED));
      }
    }

    [Column(Storage = "_DG_CAUSEDISC", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_CAUSEDISC
    {
      get => this._DG_CAUSEDISC;
      set
      {
        int? dgCausedisc = this._DG_CAUSEDISC;
        int? nullable = value;
        if ((dgCausedisc.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgCausedisc.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_CAUSEDISC = value;
        this.SendPropertyChanged(nameof (DG_CAUSEDISC));
      }
    }

    [Column(Storage = "_DG_VISADATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_VISADATE
    {
      get => this._DG_VISADATE;
      set
      {
        DateTime? dgVisadate = this._DG_VISADATE;
        DateTime? nullable = value;
        if ((dgVisadate.HasValue != nullable.HasValue ? 1 : (!dgVisadate.HasValue ? 0 : (dgVisadate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_VISADATE = value;
        this.SendPropertyChanged(nameof (DG_VISADATE));
      }
    }

    [Column(Storage = "_DG_PPAYMENTDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_PPAYMENTDATE
    {
      get => this._DG_PPAYMENTDATE;
      set
      {
        DateTime? dgPpaymentdate = this._DG_PPAYMENTDATE;
        DateTime? nullable = value;
        if ((dgPpaymentdate.HasValue != nullable.HasValue ? 1 : (!dgPpaymentdate.HasValue ? 0 : (dgPpaymentdate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PPAYMENTDATE = value;
        this.SendPropertyChanged(nameof (DG_PPAYMENTDATE));
      }
    }

    [Column(Storage = "_DG_PAYMENTDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_PAYMENTDATE
    {
      get => this._DG_PAYMENTDATE;
      set
      {
        DateTime? dgPaymentdate = this._DG_PAYMENTDATE;
        DateTime? nullable = value;
        if ((dgPaymentdate.HasValue != nullable.HasValue ? 1 : (!dgPaymentdate.HasValue ? 0 : (dgPaymentdate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PAYMENTDATE = value;
        this.SendPropertyChanged(nameof (DG_PAYMENTDATE));
      }
    }

    [Column(Storage = "_DG_TURPUTDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_TURPUTDATE
    {
      get => this._DG_TURPUTDATE;
      set
      {
        DateTime? dgTurputdate = this._DG_TURPUTDATE;
        DateTime? nullable = value;
        if ((dgTurputdate.HasValue != nullable.HasValue ? 1 : (!dgTurputdate.HasValue ? 0 : (dgTurputdate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_TURPUTDATE = value;
        this.SendPropertyChanged(nameof (DG_TURPUTDATE));
      }
    }

    [Column(Storage = "_DG_DOCUMENT", DbType = "VarChar(250)", UpdateCheck = UpdateCheck.Never)]
    public string DG_DOCUMENT
    {
      get => this._DG_DOCUMENT;
      set
      {
        if (!(this._DG_DOCUMENT != value))
          return;
        this.SendPropertyChanging();
        this._DG_DOCUMENT = value;
        this.SendPropertyChanged(nameof (DG_DOCUMENT));
      }
    }

    [Column(Storage = "_DG_TURPUTPLACE", DbType = "VarChar(128)", UpdateCheck = UpdateCheck.Never)]
    public string DG_TURPUTPLACE
    {
      get => this._DG_TURPUTPLACE;
      set
      {
        if (!(this._DG_TURPUTPLACE != value))
          return;
        this.SendPropertyChanging();
        this._DG_TURPUTPLACE = value;
        this.SendPropertyChanged(nameof (DG_TURPUTPLACE));
      }
    }

    [Column(Storage = "_DG_PROCENT", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_PROCENT
    {
      get => this._DG_PROCENT;
      set
      {
        int? dgProcent = this._DG_PROCENT;
        int? nullable = value;
        if ((dgProcent.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgProcent.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PROCENT = value;
        this.SendPropertyChanged(nameof (DG_PROCENT));
      }
    }

    [Column(Storage = "_DG_OLDTOURDATE", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_OLDTOURDATE
    {
      get => this._DG_OLDTOURDATE;
      set
      {
        DateTime? dgOldtourdate = this._DG_OLDTOURDATE;
        DateTime? nullable = value;
        if ((dgOldtourdate.HasValue != nullable.HasValue ? 1 : (!dgOldtourdate.HasValue ? 0 : (dgOldtourdate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_OLDTOURDATE = value;
        this.SendPropertyChanged(nameof (DG_OLDTOURDATE));
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

    [Column(Storage = "_DG_TurDateBfrAnnul", DbType = "DateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_TurDateBfrAnnul
    {
      get => this._DG_TurDateBfrAnnul;
      set
      {
        DateTime? dgTurDateBfrAnnul = this._DG_TurDateBfrAnnul;
        DateTime? nullable = value;
        if ((dgTurDateBfrAnnul.HasValue != nullable.HasValue ? 1 : (!dgTurDateBfrAnnul.HasValue ? 0 : (dgTurDateBfrAnnul.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_TurDateBfrAnnul = value;
        this.SendPropertyChanged(nameof (DG_TurDateBfrAnnul));
      }
    }

    [Column(Storage = "_DG_ARKey", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_ARKey
    {
      get => this._DG_ARKey;
      set
      {
        int? dgArKey = this._DG_ARKey;
        int? nullable = value;
        if ((dgArKey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgArKey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_ARKey = value;
        this.SendPropertyChanged(nameof (DG_ARKey));
      }
    }

    [Column(Storage = "_DG_Key", DbType = "Int NOT NULL", IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
    public int DG_Key
    {
      get => this._DG_Key;
      set
      {
        if (this._DG_Key == value)
          return;
        this.SendPropertyChanging();
        this._DG_Key = value;
        this.SendPropertyChanged(nameof (DG_Key));
      }
    }

    [Column(Storage = "_DG_CodePartner", DbType = "VarChar(20)", UpdateCheck = UpdateCheck.Never)]
    public string DG_CodePartner
    {
      get => this._DG_CodePartner;
      set
      {
        if (!(this._DG_CodePartner != value))
          return;
        this.SendPropertyChanging();
        this._DG_CodePartner = value;
        this.SendPropertyChanged(nameof (DG_CodePartner));
      }
    }

    [Column(Storage = "_DG_FilialKey", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_FilialKey
    {
      get => this._DG_FilialKey;
      set
      {
        if (this._DG_FilialKey == value)
          return;
        if (this._tbl_Partner.HasLoadedOrAssignedValue)
          throw new ForeignKeyReferenceAlreadyHasValueException();
        this.SendPropertyChanging();
        this._DG_FilialKey = value;
        this.SendPropertyChanged(nameof (DG_FilialKey));
      }
    }

    [Column(Storage = "_DG_IsOutDoc", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_IsOutDoc
    {
      get => this._DG_IsOutDoc;
      set
      {
        if (this._DG_IsOutDoc == value)
          return;
        this.SendPropertyChanging();
        this._DG_IsOutDoc = value;
        this.SendPropertyChanged(nameof (DG_IsOutDoc));
      }
    }

    [Column(Storage = "_DG_AgentID", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_AgentID
    {
      get => this._DG_AgentID;
      set
      {
        int? dgAgentId = this._DG_AgentID;
        int? nullable = value;
        if ((dgAgentId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgAgentId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_AgentID = value;
        this.SendPropertyChanged(nameof (DG_AgentID));
      }
    }

    [Column(Storage = "_DG_TRANSFERRED", DbType = "SmallInt", UpdateCheck = UpdateCheck.Never)]
    public short? DG_TRANSFERRED
    {
      get => this._DG_TRANSFERRED;
      set
      {
        short? dgTransferred = this._DG_TRANSFERRED;
        short? nullable = value;
        if (((int) dgTransferred.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgTransferred.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_TRANSFERRED = value;
        this.SendPropertyChanged(nameof (DG_TRANSFERRED));
      }
    }

    [Column(Storage = "_DG_NOTES", DbType = "VarChar(250)", UpdateCheck = UpdateCheck.Never)]
    public string DG_NOTES
    {
      get => this._DG_NOTES;
      set
      {
        if (!(this._DG_NOTES != value))
          return;
        this.SendPropertyChanging();
        this._DG_NOTES = value;
        this.SendPropertyChanged(nameof (DG_NOTES));
      }
    }

    [Column(Storage = "_DG_INVOICECOST", DbType = "Float", UpdateCheck = UpdateCheck.Never)]
    public double? DG_INVOICECOST
    {
      get => this._DG_INVOICECOST;
      set
      {
        double? dgInvoicecost = this._DG_INVOICECOST;
        double? nullable = value;
        if ((dgInvoicecost.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgInvoicecost.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_INVOICECOST = value;
        this.SendPropertyChanged(nameof (DG_INVOICECOST));
      }
    }

    [Column(Storage = "_DG_DCRCLIENT", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_DCRCLIENT
    {
      get => this._DG_DCRCLIENT;
      set
      {
        int? dgDcrclient = this._DG_DCRCLIENT;
        int? nullable = value;
        if ((dgDcrclient.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDcrclient.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DCRCLIENT = value;
        this.SendPropertyChanged(nameof (DG_DCRCLIENT));
      }
    }

    [Column(Storage = "_DG_DCRPAYMENT", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_DCRPAYMENT
    {
      get => this._DG_DCRPAYMENT;
      set
      {
        int? dgDcrpayment = this._DG_DCRPAYMENT;
        int? nullable = value;
        if ((dgDcrpayment.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDcrpayment.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DCRPAYMENT = value;
        this.SendPropertyChanged(nameof (DG_DCRPAYMENT));
      }
    }

    [Column(Storage = "_DG_ISMAKEDISCOUNT", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_ISMAKEDISCOUNT
    {
      get => this._DG_ISMAKEDISCOUNT;
      set
      {
        int? dgIsmakediscount = this._DG_ISMAKEDISCOUNT;
        int? nullable = value;
        if ((dgIsmakediscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgIsmakediscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_ISMAKEDISCOUNT = value;
        this.SendPropertyChanged(nameof (DG_ISMAKEDISCOUNT));
      }
    }

    [Column(Storage = "_DG_DISCSUMBFRANN", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_DISCSUMBFRANN
    {
      get => this._DG_DISCSUMBFRANN;
      set
      {
        Decimal? dgDiscsumbfrann = this._DG_DISCSUMBFRANN;
        Decimal? nullable = value;
        if ((dgDiscsumbfrann.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDiscsumbfrann.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DISCSUMBFRANN = value;
        this.SendPropertyChanged(nameof (DG_DISCSUMBFRANN));
      }
    }

    [Column(Storage = "_DG_PRICEBFRANN", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_PRICEBFRANN
    {
      get => this._DG_PRICEBFRANN;
      set
      {
        Decimal? dgPricebfrann = this._DG_PRICEBFRANN;
        Decimal? nullable = value;
        if ((dgPricebfrann.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgPricebfrann.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_PRICEBFRANN = value;
        this.SendPropertyChanged(nameof (DG_PRICEBFRANN));
      }
    }

    [Column(Storage = "_DG_RazmerP", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_RazmerP
    {
      get => this._DG_RazmerP;
      set
      {
        Decimal? dgRazmerP = this._DG_RazmerP;
        Decimal? nullable = value;
        if ((dgRazmerP.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgRazmerP.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_RazmerP = value;
        this.SendPropertyChanged(nameof (DG_RazmerP));
      }
    }

    [Column(Storage = "_DG_LEADDEPARTMENT", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_LEADDEPARTMENT
    {
      get => this._DG_LEADDEPARTMENT;
      set
      {
        if (this._DG_LEADDEPARTMENT == value)
          return;
        this.SendPropertyChanging();
        this._DG_LEADDEPARTMENT = value;
        this.SendPropertyChanged(nameof (DG_LEADDEPARTMENT));
      }
    }

    [Column(Storage = "_DG_MAINMENEMAIL", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMENEMAIL
    {
      get => this._DG_MAINMENEMAIL;
      set
      {
        if (!(this._DG_MAINMENEMAIL != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMENEMAIL = value;
        this.SendPropertyChanged(nameof (DG_MAINMENEMAIL));
      }
    }

    [Column(Storage = "_DG_MAINMENCOMMENT", DbType = "VarChar(50)", UpdateCheck = UpdateCheck.Never)]
    public string DG_MAINMENCOMMENT
    {
      get => this._DG_MAINMENCOMMENT;
      set
      {
        if (!(this._DG_MAINMENCOMMENT != value))
          return;
        this.SendPropertyChanging();
        this._DG_MAINMENCOMMENT = value;
        this.SendPropertyChanged(nameof (DG_MAINMENCOMMENT));
      }
    }

    [Column(Storage = "_DG_DUPUSERKEY", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_DUPUSERKEY
    {
      get => this._DG_DUPUSERKEY;
      set
      {
        int? dgDupuserkey = this._DG_DUPUSERKEY;
        int? nullable = value;
        if ((dgDupuserkey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDupuserkey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DUPUSERKEY = value;
        this.SendPropertyChanged(nameof (DG_DUPUSERKEY));
      }
    }

    [Column(Storage = "_DG_BTKEY", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_BTKEY
    {
      get => this._DG_BTKEY;
      set
      {
        int? dgBtkey = this._DG_BTKEY;
        int? nullable = value;
        if ((dgBtkey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgBtkey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_BTKEY = value;
        this.SendPropertyChanged(nameof (DG_BTKEY));
      }
    }

    [Column(Storage = "_DG_ConfirmedDate", DbType = "SmallDateTime", UpdateCheck = UpdateCheck.Never)]
    public DateTime? DG_ConfirmedDate
    {
      get => this._DG_ConfirmedDate;
      set
      {
        DateTime? dgConfirmedDate = this._DG_ConfirmedDate;
        DateTime? nullable = value;
        if ((dgConfirmedDate.HasValue != nullable.HasValue ? 1 : (!dgConfirmedDate.HasValue ? 0 : (dgConfirmedDate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_ConfirmedDate = value;
        this.SendPropertyChanged(nameof (DG_ConfirmedDate));
      }
    }

    [Column(Storage = "_DG_PRTDOGKEY", DbType = "Int NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public int DG_PRTDOGKEY
    {
      get => this._DG_PRTDOGKEY;
      set
      {
        if (this._DG_PRTDOGKEY == value)
          return;
        this.SendPropertyChanging();
        this._DG_PRTDOGKEY = value;
        this.SendPropertyChanged(nameof (DG_PRTDOGKEY));
      }
    }

    [Column(Storage = "_DG_CTDepartureKey", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_CTDepartureKey
    {
      get => this._DG_CTDepartureKey;
      set
      {
        int? dgCtDepartureKey = this._DG_CTDepartureKey;
        int? nullable = value;
        if ((dgCtDepartureKey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgCtDepartureKey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_CTDepartureKey = value;
        this.SendPropertyChanged(nameof (DG_CTDepartureKey));
      }
    }

    [Column(Storage = "_DG_SalePrice", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_SalePrice
    {
      get => this._DG_SalePrice;
      set
      {
        Decimal? dgSalePrice = this._DG_SalePrice;
        Decimal? nullable = value;
        if ((dgSalePrice.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgSalePrice.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_SalePrice = value;
        this.SendPropertyChanged(nameof (DG_SalePrice));
      }
    }

    [Column(Storage = "_DG_SaleDiscount", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_SaleDiscount
    {
      get => this._DG_SaleDiscount;
      set
      {
        Decimal? dgSaleDiscount = this._DG_SaleDiscount;
        Decimal? nullable = value;
        if ((dgSaleDiscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgSaleDiscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_SaleDiscount = value;
        this.SendPropertyChanged(nameof (DG_SaleDiscount));
      }
    }

    [Column(Storage = "_DG_PDTType", DbType = "SmallInt NOT NULL", UpdateCheck = UpdateCheck.Never)]
    public short DG_PDTType
    {
      get => this._DG_PDTType;
      set
      {
        if ((int) this._DG_PDTType == (int) value)
          return;
        this.SendPropertyChanging();
        this._DG_PDTType = value;
        this.SendPropertyChanged(nameof (DG_PDTType));
      }
    }

    [Column(Storage = "_DG_NATIONALCURRENCYPRICE", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_NATIONALCURRENCYPRICE
    {
      get => this._DG_NATIONALCURRENCYPRICE;
      set
      {
        Decimal? nationalcurrencyprice = this._DG_NATIONALCURRENCYPRICE;
        Decimal? nullable = value;
        if ((nationalcurrencyprice.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (nationalcurrencyprice.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_NATIONALCURRENCYPRICE = value;
        this.SendPropertyChanged(nameof (DG_NATIONALCURRENCYPRICE));
      }
    }

    [Column(Storage = "_DG_NATIONALCURRENCYDISCOUNTSUM", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_NATIONALCURRENCYDISCOUNTSUM
    {
      get => this._DG_NATIONALCURRENCYDISCOUNTSUM;
      set
      {
        Decimal? nationalcurrencydiscountsum = this._DG_NATIONALCURRENCYDISCOUNTSUM;
        Decimal? nullable = value;
        if ((nationalcurrencydiscountsum.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (nationalcurrencydiscountsum.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_NATIONALCURRENCYDISCOUNTSUM = value;
        this.SendPropertyChanged(nameof (DG_NATIONALCURRENCYDISCOUNTSUM));
      }
    }

    [Column(Storage = "_DG_DAKey", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_DAKey
    {
      get => this._DG_DAKey;
      set
      {
        int? dgDaKey = this._DG_DAKey;
        int? nullable = value;
        if ((dgDaKey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgDaKey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_DAKey = value;
        this.SendPropertyChanged(nameof (DG_DAKey));
      }
    }

    [Column(Storage = "_DG_NATIONALCURRENCYPAYED", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_NATIONALCURRENCYPAYED
    {
      get => this._DG_NATIONALCURRENCYPAYED;
      set
      {
        Decimal? nationalcurrencypayed = this._DG_NATIONALCURRENCYPAYED;
        Decimal? nullable = value;
        if ((nationalcurrencypayed.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (nationalcurrencypayed.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_NATIONALCURRENCYPAYED = value;
        this.SendPropertyChanged(nameof (DG_NATIONALCURRENCYPAYED));
      }
    }

    [Column(Storage = "_DG_CurrencyKey", DbType = "Int", UpdateCheck = UpdateCheck.Never)]
    public int? DG_CurrencyKey
    {
      get => this._DG_CurrencyKey;
      set
      {
        int? dgCurrencyKey = this._DG_CurrencyKey;
        int? nullable = value;
        if ((dgCurrencyKey.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgCurrencyKey.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_CurrencyKey = value;
        this.SendPropertyChanged(nameof (DG_CurrencyKey));
      }
    }

    [Column(Storage = "_DG_CurrencyRate", DbType = "Money", UpdateCheck = UpdateCheck.Never)]
    public Decimal? DG_CurrencyRate
    {
      get => this._DG_CurrencyRate;
      set
      {
        Decimal? dgCurrencyRate = this._DG_CurrencyRate;
        Decimal? nullable = value;
        if ((dgCurrencyRate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (dgCurrencyRate.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_CurrencyRate = value;
        this.SendPropertyChanged(nameof (DG_CurrencyRate));
      }
    }

    [Column(Storage = "_DG_ProTourFlag", DbType = "TinyInt", UpdateCheck = UpdateCheck.Never)]
    public byte? DG_ProTourFlag
    {
      get => this._DG_ProTourFlag;
      set
      {
        byte? dgProTourFlag = this._DG_ProTourFlag;
        byte? nullable = value;
        if (((int) dgProTourFlag.GetValueOrDefault() != (int) nullable.GetValueOrDefault() ? 1 : (dgProTourFlag.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DG_ProTourFlag = value;
        this.SendPropertyChanged(nameof (DG_ProTourFlag));
      }
    }

    [Association(Name = "tbl_Partner_tbl_Dogovor", Storage = "_tbl_Partner", ThisKey = "DG_FilialKey", OtherKey = "PR_KEY", IsForeignKey = true)]
    public tbl_Partner tbl_Partner
    {
      get => this._tbl_Partner.Entity;
      set
      {
        tbl_Partner entity = this._tbl_Partner.Entity;
        if (entity == value && this._tbl_Partner.HasLoadedOrAssignedValue)
          return;
        this.SendPropertyChanging();
        if (entity != null)
        {
          this._tbl_Partner.Entity = (tbl_Partner) null;
          entity.tbl_Dogovors.Remove(this);
        }
        this._tbl_Partner.Entity = value;
        if (value != null)
        {
          value.tbl_Dogovors.Add(this);
          this._DG_FilialKey = value.PR_KEY;
        }
        else
          this._DG_FilialKey = 0;
        this.SendPropertyChanged(nameof (tbl_Partner));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, tbl_Dogovor.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
