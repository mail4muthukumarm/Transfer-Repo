// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.QuoteTransformation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

public class QuoteTransformation
{
  private Guid _oldQuoteguid;
  private Guid _newLineGuid;
  private Guid _newQuoteGuid;
  private Guid? _newSubmissionGroupGuid;
  private readonly int? _raterID;
  private readonly Guid? _newQuoteCompanyLocationGuid;

  public QuoteTransformation(Guid oldQuoteGuid, Guid newLineGuid)
  {
    this._oldQuoteguid = oldQuoteGuid;
    this._newLineGuid = newLineGuid;
  }

  public QuoteTransformation(Guid oldQuoteGuid, Guid newLineGuid, Guid newQuoteCompanyLocationGuid)
    : this(oldQuoteGuid, newLineGuid, (object) null)
  {
    this._newQuoteCompanyLocationGuid = new Guid?(newQuoteCompanyLocationGuid);
  }

  public QuoteTransformation(Guid oldQuoteGuid, Guid newLineGuid, object raterID)
  {
    this._oldQuoteguid = oldQuoteGuid;
    this._newLineGuid = newLineGuid;
    this._raterID = Utility.IsNull<int?>(RuntimeHelpers.GetObjectValue(raterID), new int?());
  }

  public QuoteTransformation(
    Guid oldQuoteGuid,
    Guid newLineGuid,
    object raterID,
    object newSubmissionGroupGuid)
    : this(oldQuoteGuid, newLineGuid, RuntimeHelpers.GetObjectValue(raterID))
  {
    this._newSubmissionGroupGuid = Utility.IsNull<Guid?>(RuntimeHelpers.GetObjectValue(newSubmissionGroupGuid), new Guid?());
  }

  public static void ResetQuoteDetails(Guid oldQuoteGuid, Quote newQuote, int raterID)
  {
    ProducerLocation objectAs1 = ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) newQuote.ProducerLocationGuid);
    bool isRenewal = newQuote.IsRenewal;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyLineGUID FROM dbo.tblCompanyLines WITH (NOLOCK) WHERE ParentCompanyLineGUID = @PG", new object[2]
    {
      (object) "@PG",
      (object) newQuote.CompanyLineGuid
    });
    try
    {
      if (dataTable.Rows.Count == 0)
      {
        CompanyLine objectAs2 = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) newQuote.CompanyLocationGuid, (object) newQuote.LineGuid, (object) newQuote.StateID, null);
        Decimal commission1 = objectAs1.GetCommission(objectAs2.CompanyLineGuid, isRenewal, newQuote.EffectiveDate, (SqlTransaction) null, (object) newQuote.PolicyTypeID, (object) null, newQuote.QuotingLocationGuid);
        Decimal commission2 = objectAs2.GetCommission(isRenewal, newQuote.ProducerLocationGuid, commission1, newQuote.EffectiveDate, newQuote.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, newQuote.QuotingLocationGuid);
        DefaultDatabase.ExecuteNonQuery("TransFormUpdateQuoteDetails", new object[12]
        {
          (object) "@OldQuoteGuid",
          (object) oldQuoteGuid,
          (object) "@NewQuoteGuid",
          (object) newQuote.QuoteGuid,
          (object) "@CompanyCommission",
          (object) commission2,
          (object) "@ProducerCommission",
          (object) commission1,
          (object) "@RaterID",
          (object) raterID,
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      else
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteDetails WHERE QuoteGuid = @QG", new object[2]
        {
          (object) "@QG",
          (object) newQuote.QuoteGuid
        });
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            CompanyLine objectAs3 = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) (Guid) row[0]);
            Decimal commission3 = objectAs1.GetCommission((Guid) row[0], isRenewal, newQuote.EffectiveDate, (SqlTransaction) null, (object) newQuote.PolicyTypeID, (object) null, newQuote.QuotingLocationGuid);
            Decimal commission4 = objectAs3.GetCommission(isRenewal, newQuote.ProducerLocationGuid, commission3, newQuote.EffectiveDate, newQuote.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, newQuote.QuotingLocationGuid);
            DefaultDatabase.ExecuteNonQuery("TransFormCreateQuoteDetails", new object[14]
            {
              (object) "@OldQuoteGuid",
              (object) oldQuoteGuid,
              (object) "@NewQuoteGuid",
              (object) newQuote.QuoteGuid,
              (object) "@CompanyLineGuid",
              (object) (Guid) row[0],
              (object) "@CompanyCommission",
              (object) commission4,
              (object) "@ProducerCommission",
              (object) commission3,
              (object) "@RaterID",
              (object) raterID,
              (object) "@CurrentUserGuid",
              (object) CurrentUser.Instance.UserGUID
            });
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
  }

  public Guid TransForm()
  {
    Quote quote1 = Quote.CreateNew(this._oldQuoteguid);
    this._newQuoteGuid = !this._newSubmissionGroupGuid.HasValue ? quote1.Copy() : quote1.Copy(this._newSubmissionGroupGuid.Value);
    DefaultDatabase.ExecuteNonQuery("TransFormQuoteRecord", new object[10]
    {
      (object) "@OldQuoteGuid",
      (object) this._oldQuoteguid,
      (object) "@NewQuoteGuid",
      (object) this._newQuoteGuid,
      (object) "@NewLineGuid",
      (object) this._newLineGuid,
      (object) "@NewQuoteCompanyLocationGuid",
      (object) this._newQuoteCompanyLocationGuid,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    Quote quote2 = Quote.CreateNew(this._newQuoteGuid);
    ProducerLocation objectAs1 = ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) quote2.ProducerLocationGuid);
    bool isRenewal = quote2.IsRenewal;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyLineGUID FROM dbo.tblCompanyLines WITH (NOLOCK) WHERE ParentCompanyLineGUID = @PG", new object[2]
    {
      (object) "@PG",
      (object) quote2.CompanyLineGuid
    });
    try
    {
      if (dataTable.Rows.Count == 0)
      {
        CompanyLine objectAs2 = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) quote2.CompanyLocationGuid, (object) quote2.LineGuid, (object) quote2.StateID, null);
        Decimal commission = objectAs1.GetCommission(objectAs2.CompanyLineGuid, isRenewal, quote2.EffectiveDate, (SqlTransaction) null, (object) quote2.PolicyTypeID, (object) null, quote2.QuotingLocationGuid);
        DefaultDatabase.ExecuteNonQuery("TransFormUpdateQuoteDetails", new object[12]
        {
          (object) "@OldQuoteGuid",
          (object) this._oldQuoteguid,
          (object) "@NewQuoteGuid",
          (object) this._newQuoteGuid,
          (object) "@CompanyCommission",
          (object) objectAs2.GetCommission(isRenewal, quote2.ProducerLocationGuid, commission, quote2.EffectiveDate, quote2.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, quote2.QuotingLocationGuid),
          (object) "@ProducerCommission",
          (object) commission,
          (object) "@RaterID",
          (object) this._raterID,
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      else
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteDetails WHERE QuoteGuid = @QG", new object[2]
        {
          (object) "@QG",
          (object) quote2.QuoteGuid
        });
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            CompanyLine objectAs3 = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) (Guid) row[0]);
            Decimal commission1 = objectAs1.GetCommission((Guid) row[0], isRenewal, quote2.EffectiveDate, (SqlTransaction) null, (object) quote2.PolicyTypeID, (object) null, quote2.QuotingLocationGuid);
            Decimal commission2 = objectAs3.GetCommission(isRenewal, quote2.ProducerLocationGuid, commission1, quote2.EffectiveDate, quote2.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, quote2.QuotingLocationGuid);
            DefaultDatabase.ExecuteNonQuery("TransFormCreateQuoteDetails", new object[14]
            {
              (object) "@OldQuoteGuid",
              (object) this._oldQuoteguid,
              (object) "@NewQuoteGuid",
              (object) this._newQuoteGuid,
              (object) "@CompanyLineGuid",
              (object) (Guid) row[0],
              (object) "@CompanyCommission",
              (object) commission2,
              (object) "@ProducerCommission",
              (object) commission1,
              (object) "@RaterID",
              (object) this._raterID,
              (object) "@CurrentUserGuid",
              (object) CurrentUser.Instance.UserGUID
            });
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
    return this._newQuoteGuid;
  }
}
