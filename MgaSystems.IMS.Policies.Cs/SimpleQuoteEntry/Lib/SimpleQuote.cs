// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.SimpleQuote
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public abstract class SimpleQuote : ValidatingBindingObject
{
  private Guid controlGuid;
  public int ProgramCodeID;

  public int ControlNo { get; set; }

  public Guid QuoteGuid { get; set; }

  [NotificationProperty]
  public virtual byte InsuredTypeID { get; set; }

  [NotificationProperty]
  public virtual Submission Submission { get; set; }

  [NotificationProperty]
  public virtual Quote Quote { get; set; }

  [NotificationProperty]
  public virtual bool CanCreateQuote { get; set; }

  public static SimpleQuote Create() => NotifyProxyTypeManager.Allocate<SimpleQuote>();

  public SimpleQuote()
  {
    this.controlGuid = Guid.NewGuid();
    this.QuoteGuid = Guid.NewGuid();
    this.Submission = Submission.Create();
    this.Quote = Quote.Create(this);
    this.CanCreateQuote = true;
  }

  public void SetProgramCode()
  {
    if (this.Quote == null || this.Submission.QuoteEditCode.ProgramCodes == null)
      return;
    this.ProgramCodeID = -1;
    this.ControlNo = -1;
    IEnumerable<ProgramCode> source = this.Submission.QuoteEditCode.ProgramCodes.Where<ProgramCode>((System.Func<ProgramCode, bool>) (c => (c.LineGuid == this.Quote.LineGuid || c.LineGuid == Guid.Empty) && (c.StateID == this.Quote.StateID || c.StateID == "&&") && (c.IssuingOfficeGuid == this.Quote.IssuingOfficeGuid || c.IssuingOfficeGuid == Guid.Empty) && (c.CompanyLocationGuid == this.Quote.CompanyLocationGuid || c.CompanyLocationGuid == Guid.Empty) && (string.IsNullOrEmpty(c.GroupCode) || c.GroupCode == this.Submission.QuoteEditCode.GetLineGroupProgramCode(this.Quote.LineGuid) || c.GroupCode == "&&") && this.Quote.EffectiveDate >= c.ContractEffective && this.Quote.EffectiveDate <= c.ContractExpiration));
    if (source.FirstOrDefault<ProgramCode>() == null)
      return;
    foreach (QuoteDetail quoteDetail in (Collection<QuoteDetail>) this.Quote.QuoteDetails)
    {
      quoteDetail.ProgramCodeID = source.FirstOrDefault<ProgramCode>().ProgramID;
      this.ProgramCodeID = quoteDetail.ProgramCodeID;
    }
  }

  public List<string> ValidateSimpleQuote()
  {
    List<string> stringList = new List<string>();
    if (this.Submission.InsuredTypeID == (byte) 0)
      stringList.Add("Must select Type");
    if (this.Submission.ProducerLocationGuid == Guid.Empty)
      stringList.Add("Must select Producer");
    if (this.Submission.IsIndividual)
    {
      if (string.IsNullOrEmpty(this.Submission.LastName))
        stringList.Add("Must enter Name");
    }
    else if (string.IsNullOrEmpty(this.Submission.InsuredBusinessName))
      stringList.Add("Must enter Business Name");
    if (string.IsNullOrEmpty(this.Submission.PolicyName))
      stringList.Add("Must enter Name on Policy");
    if (string.IsNullOrEmpty(this.Submission.Description))
      stringList.Add("Must enter Description");
    if (string.IsNullOrEmpty(this.Submission.Address1))
      stringList.Add("Must enter Address");
    if (string.IsNullOrEmpty(this.Submission.ZipCode))
      stringList.Add("Must enter Zip Code");
    if (this.Quote.QuotingOfficeGuid == Guid.Empty)
      stringList.Add("Must select Quoting Office");
    if (this.Quote.UseMulticurrency && string.IsNullOrEmpty(this.Quote.CurrencyCode))
      stringList.Add("Must select currency code");
    if (this.Quote.LineGuid == Guid.Empty)
      stringList.Add("Must select Line");
    if (string.IsNullOrEmpty(this.Quote.StateID))
      stringList.Add("Must select State");
    if (this.Quote.CompanyLocationGuid == Guid.Empty)
      stringList.Add("Must select Company");
    if (this.Quote.BillingTypeID <= 0)
      stringList.Add("Must select Billing Type");
    if (this.Quote.IssuingOfficeGuid == Guid.Empty)
      stringList.Add("Must select Issuing Office");
    if (this.Quote.UnderwriterGuid == Guid.Empty)
      stringList.Add("Must select Underwriter");
    if (this.Quote.PolicyTypeID <= (byte) 0)
      stringList.Add("Must select Policy Type");
    if (this.Quote.CostCenterID == 0)
      stringList.Add("Must select Cost Center");
    return stringList;
  }

  private void CreateSubmissionGroup()
  {
    this.Submission.SubmissionGroupGuid = Guid.NewGuid();
    DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spSubmissionGroupUpdate", new object[20]
    {
      (object) "@SubmissionGroupGuid",
      (object) this.Submission.SubmissionGroupGuid,
      (object) "@InsuredGuid",
      (object) this.Submission.InsuredGuid,
      (object) "@ProducerLocationGuid",
      (object) this.Submission.ProducerLocationGuid,
      (object) "@UnderwriterUserGuid",
      (object) this.Quote.UnderwriterGuid,
      (object) "@TACSRUserGuid",
      null,
      (object) "@DateSubmitted",
      (object) DateTime.Now,
      (object) "@InHouseProducerUserGuid",
      null,
      (object) "@AddedByUserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@ProducerContactID",
      (object) this.Submission.ProducerContactID,
      (object) "@SecProducerContactID",
      null
    });
    CurrentUser.Instance.LogAction("New Submission", this.Submission.SubmissionGroupGuid);
  }

  public void CreateQuote()
  {
    this.CreateSubmissionGroup();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      this.SaveQuote();
      e.Transaction.Commit();
    }));
    if (this.ControlNo <= -1)
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.NewQuote, (object) this.QuoteGuid);
    Messaging.SendBroadcastMessage(BroadcastMessages.FirstQuoteOnSubmission, (object) this.QuoteGuid);
    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteModified, (object) this.QuoteGuid);
    CurrentUser.Instance.LogAction($"New Quote - Control # {this.ControlNo}", this.QuoteGuid);
  }

  private void SaveQuote()
  {
    try
    {
      this.ControlNo = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ISNULL(MAX(ControlNo)+ 1, 1) FROM tblQuotes");
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spCreateSimpleQuote", new object[36]
      {
        (object) "@StateID",
        (object) this.Quote.StateID,
        (object) "@UnderwriterUserGuid",
        (object) this.Quote.UnderwriterGuid,
        (object) "@LineGUID",
        (object) this.Quote.LineGuid,
        (object) "@CompanyLocationGuid",
        (object) this.Quote.CompanyLocationGuid,
        (object) "@EffectiveDate",
        (object) this.Quote.EffectiveDate,
        (object) "@ExpirationDate",
        (object) this.Quote.ExpirationDate,
        (object) "@QuotingLocationGuid",
        (object) this.Quote.QuotingOfficeGuid,
        (object) "@IssuingLocationGuid",
        (object) this.Quote.IssuingOfficeGuid,
        (object) "@ProducerContactGuid",
        (object) this.Submission.ProducerContactGuid,
        (object) "@PolicyTypeID",
        (object) this.Quote.PolicyTypeID,
        (object) "@SubmissionGroupGuid",
        (object) this.Submission.SubmissionGroupGuid,
        (object) "@QuoteGUID",
        (object) this.QuoteGuid,
        (object) "@BillingTypeID",
        (object) this.Quote.BillingTypeID,
        (object) "@ControlNo",
        (object) this.ControlNo,
        (object) "@ControlGuid",
        (object) this.controlGuid,
        (object) "@MinimumEarnedPercentage",
        (object) this.Quote.MinimumEarnedPercentage,
        (object) "@CostCenterID",
        (object) this.Quote.CostCenterID,
        (object) "@ProducerLocationID",
        (object) this.Submission.ProducerLocationID
      });
      int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT MAX(QuoteID) FROM tblQuotes WHERE ControlNo = @ControlNo", new object[2]
      {
        (object) "@ControlNo",
        (object) this.ControlNo
      });
      int? nullable1 = new int?();
      if (this.ProgramCodeID != -1)
        nullable1 = new int?(((Collection<QuoteDetail>) this.Quote.QuoteDetails)[0].ProgramCodeID);
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.SaveQuote2", new object[6]
      {
        (object) "@QuoteID",
        (object) num,
        (object) "@CurrencyCode",
        (object) this.Quote.CurrencyCode,
        (object) "@ProgramID",
        (object) nullable1
      });
      foreach (QuoteDetail quoteDetail in (Collection<QuoteDetail>) this.Quote.QuoteDetails)
      {
        Guid? nullable2 = new Guid?();
        Guid? nullable3 = new Guid?();
        if (quoteDetail.CompanyContactGuid != Guid.Empty)
          nullable3 = new Guid?(quoteDetail.CompanyContactGuid);
        if (quoteDetail.IntermediaryContactGuid != Guid.Empty)
          nullable2 = new Guid?(quoteDetail.IntermediaryContactGuid);
        DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spCreateSimpleQuoteDetails", new object[16 /*0x10*/]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid,
          (object) "@CompanyLineGuid",
          (object) quoteDetail.CompanyLineGuid,
          (object) "@CompanyContactGuid",
          (object) nullable3,
          (object) "@CompanyCommission",
          (object) quoteDetail.CompanyCommission,
          (object) "@ProducerCommission",
          (object) quoteDetail.ProducerCommission,
          (object) "@TermsOfPayment",
          (object) quoteDetail.TermsOfPayment,
          (object) "@IntermediaryContactGuid",
          (object) nullable2,
          (object) "@ProgramID",
          (object) quoteDetail.ProgramCodeID
        });
      }
      this.SaveClientData();
    }
    catch
    {
      this.ControlNo = -1;
      throw;
    }
  }

  public virtual void SaveClientData()
  {
  }
}
