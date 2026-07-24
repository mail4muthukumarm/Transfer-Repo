// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.QuoteDetail
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public abstract class QuoteDetail : BindingObject
{
  public Quote Parent { get; set; }

  public Guid CompanyLineGuid { get; set; }

  public string CompanyLine { get; set; }

  public string CompanyContact { get; set; }

  public Decimal CompanyCommission { get; set; }

  public Decimal ProducerCommission { get; set; }

  [NotificationProperty]
  public virtual int ProgramCodeID { get; set; }

  public short TermsOfPayment { get; set; }

  public bool UsingAdditiveCommission { get; set; }

  [NotificationProperty]
  public virtual Guid CompanyContactGuid { get; set; }

  [NotificationProperty]
  public virtual Guid IntermediaryContactGuid { get; set; }

  public bool UsingIntermediary { get; set; }

  public ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact> CompanyContacts { get; } = new ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact>();

  public ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact> IntermediaryContacts { get; } = new ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact>();

  internal static QuoteDetail Create(
    Quote parent,
    Guid companyLineGuid,
    string companyLine,
    short termsOfPayment,
    bool usingAdditiveCommission)
  {
    return NotifyProxyTypeManager.Allocate<QuoteDetail>(new object[5]
    {
      (object) parent,
      (object) companyLineGuid,
      (object) companyLine,
      (object) termsOfPayment,
      (object) usingAdditiveCommission
    });
  }

  public QuoteDetail(
    Quote parent,
    Guid companyLineGuid,
    string companyLine,
    short termsOfPayment,
    bool usingAdditiveCommission)
  {
    this.Parent = parent;
    this.CompanyLineGuid = companyLineGuid;
    this.CompanyLine = companyLine;
    this.TermsOfPayment = termsOfPayment;
    this.UsingAdditiveCommission = usingAdditiveCommission;
    this.UsingIntermediary = new MGASystems.BusinessObjects.CompanyLocation(this.Parent.CompanyLocationGuid).UsingIntermediary;
    if (this.UsingIntermediary)
      this.IntermediaryContacts = new ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact>((IEnumerable<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.QuoteEditData_GetCompanyContacts", new object[4]
      {
        (object) "@companyLineGuid",
        (object) companyLineGuid,
        (object) "@includeCompanyContacts",
        (object) false
      }).AsEnumerable().Select<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact>((System.Func<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact>) (row => new MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.IntermediaryContact()
      {
        CompanyLocationGuid = row.Field<Guid>("CompanyLocationGuid"),
        IntermediaryContactGuid = row.Field<Guid>(nameof (IntermediaryContactGuid)),
        Name = row.Field<string>("Name")
      })));
    this.CompanyContacts = new ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact>((IEnumerable<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.QuoteEditData_GetCompanyContacts", new object[4]
    {
      (object) "@companyLineGuid",
      (object) companyLineGuid,
      (object) "@includeCompanyContacts",
      (object) true
    }).AsEnumerable().Select<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact>((System.Func<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact>) (row => new MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.CompanyContact()
    {
      CompanyLocationGuid = row.Field<Guid>("CompanyLocationGuid"),
      CompanyContactGuid = row.Field<Guid>(nameof (CompanyContactGuid)),
      Name = row.Field<string>("Name")
    })));
    this.ProducerCommission = new ProducerLocation(this.Parent.Parent.Submission.ProducerLocationGuid).GetCommission(companyLineGuid, this.Parent.IsCommissionRenewal, this.Parent.EffectiveDate, (SqlTransaction) null, (object) this.Parent.PolicyTypeID, (object) this.ProgramCodeID, this.Parent.QuotingOfficeGuid);
    this.CompanyCommission = new MGASystems.BusinessObjects.CompanyLine(this.CompanyLineGuid).GetCommission(false, this.Parent.Parent.Submission.ProducerLocationGuid, this.ProducerCommission, this.Parent.EffectiveDate, (int) this.Parent.PolicyTypeID, (SqlTransaction) null, this.Parent.CompanyLocationGuid, (object) this.ProgramCodeID, this.Parent.QuotingOfficeGuid);
  }
}
