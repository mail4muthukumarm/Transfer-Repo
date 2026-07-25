// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Data.RaterQuoteOption
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.Data;

public class RaterQuoteOption
{
  private bool _isNew;
  private bool _isDeleted;
  private RaterBase _rater;
  private int? _quoteOptionId;
  private Guid _quoteOptionGuid;
  private Guid? _originalQuoteOptionGuid;
  private int? _companyLocationId;
  private Decimal? _premium;
  private DateTime _dateCreated;
  private bool _bound;
  private bool _quote;
  private Decimal? _totalFees;
  private string _additionalComments;
  private int? _companyInstallmentId;
  private Guid _lineGuid;

  public RaterQuoteOption(RaterBase rater)
  {
    this._rater = rater;
    this.InitializeOption(Guid.Empty);
  }

  public RaterQuoteOption(RaterBase rater, Guid quoteOptionGuid)
  {
    this._rater = rater;
    this.InitializeOption(quoteOptionGuid);
  }

  public void Delete()
  {
    if (this.IsDeleted)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete from tblQuoteOptions where quoteOptionGuid = @quoteOptionGuid", new object[2]
    {
      (object) "@quoteOptionGuid",
      (object) this.QuoteOptionGuid
    });
    this._isDeleted = true;
  }

  public void Update()
  {
    this.CheckNotDeleted();
    if (this._isNew)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblQuoteOptions(QuoteOptionGUID, QuoteGUID, LineGUID, DateCreated, AdditionalComments)values(@QuoteOptionGUID, @QuoteGUID, @LineGUID, @DateCreated, @AdditionalComments)", new object[10]
      {
        (object) "@QuoteOptionGUID",
        (object) this.QuoteOptionGuid,
        (object) "@QuoteGUID",
        (object) this.QuoteGuid,
        (object) "@LineGUID",
        (object) this.LineGuid,
        (object) "@DateCreated",
        (object) this.DateCreated,
        (object) "@AdditionalComments",
        (object) this.AdditionalComments
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblQuoteOptions set AdditionalComments = @AdditionalComments, LineGuid = @LineGuid where quoteOptionGuid = @quoteOptionGuid", new object[6]
      {
        (object) "@QuoteOptionGUID",
        (object) this.QuoteOptionGuid,
        (object) "@LineGuid",
        (object) this.LineGuid,
        (object) "@AdditionalComments",
        (object) this.AdditionalComments
      });
    this.InitializeOption(this.QuoteOptionGuid);
  }

  public bool IsDeleted
  {
    get
    {
      this.CheckNotDeleted();
      return this._isDeleted;
    }
  }

  private void CheckNotDeleted()
  {
    if (this._isDeleted)
      throw new InvalidOperationException("Cannot access a deleted row");
  }

  private void InitializeOption(Guid quoteOptionGuid)
  {
    this._quoteOptionId = new int?();
    this._quoteOptionGuid = Guid.NewGuid();
    this._originalQuoteOptionGuid = new Guid?();
    this._companyLocationId = new int?();
    this._premium = new Decimal?();
    this._dateCreated = DateTime.Now;
    this._bound = false;
    this._quote = false;
    this._totalFees = new Decimal?();
    this._additionalComments = string.Empty;
    this._companyInstallmentId = new int?();
    this._isNew = true;
    this._lineGuid = this._rater.LineGuid;
    if (!(quoteOptionGuid != Guid.Empty))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select QuoteOptionID, QuoteOptionGUID, OriginalQuoteOptionGUID, QuoteGUID, LineGUID, CompanyLocationID, Premium, DateCreated, Bound, Quote, TotalFees, AdditionalComments, CompanyInstallmentID from tblQuoteOptions where quoteOptionGuid = @quoteOptionGuid", new object[2]
    {
      (object) "@quoteOptionGuid",
      (object) quoteOptionGuid
    });
    if (dataTable.Rows.Count > 1)
      throw new ArgumentException("The option guid specified returned invalid rows", nameof (quoteOptionGuid));
    if (dataTable.Rows.Count == 1)
    {
      this._isNew = false;
      this._quoteOptionId = new int?((int) dataTable.Rows[0]["QuoteOptionID"]);
      this._quoteOptionGuid = (Guid) dataTable.Rows[0]["QuoteOptionGUID"];
      if (!dataTable.Rows[0].IsNull("OriginalQuoteOptionGUID"))
        this._originalQuoteOptionGuid = new Guid?((Guid) dataTable.Rows[0]["OriginalQuoteOptionGUID"]);
      if (!dataTable.Rows[0].IsNull("CompanyLocationID"))
        this._companyLocationId = new int?((int) dataTable.Rows[0]["CompanyLocationID"]);
      if (!dataTable.Rows[0].IsNull("LineGUID"))
        this._lineGuid = (Guid) dataTable.Rows[0]["LineGUID"];
      if (!dataTable.Rows[0].IsNull("Premium"))
        this._premium = new Decimal?(Conversions.ToDecimal(dataTable.Rows[0]["Premium"]));
      this._dateCreated = (DateTime) dataTable.Rows[0]["DateCreated"];
      this._bound = (bool) dataTable.Rows[0]["Bound"];
      this._quote = (bool) dataTable.Rows[0]["Quote"];
      if (!dataTable.Rows[0].IsNull("TotalFees"))
        this._totalFees = new Decimal?(Conversions.ToDecimal(dataTable.Rows[0]["TotalFees"]));
      if (!dataTable.Rows[0].IsNull("AdditionalComments"))
        this._additionalComments = (string) dataTable.Rows[0]["AdditionalComments"];
      if (dataTable.Rows[0].IsNull("CompanyInstallmentID"))
        return;
      this._companyInstallmentId = new int?((int) dataTable.Rows[0]["CompanyInstallmentID"]);
    }
    else
      this._quoteOptionGuid = quoteOptionGuid;
  }

  public int? QuoteOptionId
  {
    get
    {
      this.CheckNotDeleted();
      return this._quoteOptionId;
    }
  }

  public Guid QuoteOptionGuid
  {
    get
    {
      this.CheckNotDeleted();
      return this._quoteOptionGuid;
    }
  }

  public Guid? OriginalQuoteOptionGuid
  {
    get
    {
      this.CheckNotDeleted();
      return this._originalQuoteOptionGuid;
    }
  }

  public Guid QuoteGuid
  {
    get
    {
      this.CheckNotDeleted();
      return this._rater.QuoteGuid;
    }
  }

  public Guid LineGuid
  {
    get
    {
      this.CheckNotDeleted();
      return this._lineGuid;
    }
    set
    {
      this.CheckNotDeleted();
      this._lineGuid = value;
    }
  }

  public int? CompanyLocationId
  {
    get
    {
      this.CheckNotDeleted();
      return this._companyLocationId;
    }
  }

  public Decimal? Premium
  {
    get
    {
      this.CheckNotDeleted();
      return this._premium;
    }
  }

  public DateTime DateCreated
  {
    get
    {
      this.CheckNotDeleted();
      return this._dateCreated;
    }
  }

  public bool Bound
  {
    get
    {
      this.CheckNotDeleted();
      return this._bound;
    }
  }

  public bool Quote
  {
    get
    {
      this.CheckNotDeleted();
      return this._quote;
    }
  }

  public Decimal? TotalFees
  {
    get
    {
      this.CheckNotDeleted();
      return this._totalFees;
    }
  }

  public string AdditionalComments
  {
    get
    {
      this.CheckNotDeleted();
      return this._additionalComments;
    }
    set
    {
      this.CheckNotDeleted();
      this._additionalComments = value;
    }
  }

  public int? CompanyInstallmentId
  {
    get
    {
      this.CheckNotDeleted();
      return this._companyInstallmentId;
    }
  }
}
