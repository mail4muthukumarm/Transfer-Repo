// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.PoliciesStatus
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class PoliciesStatus
{
  public PoliciesStatus(
    string policyNumber,
    DateTime? effectiveDate,
    Decimal transactionAmount,
    int rowNumber,
    string optionalErrorMessage)
  {
    this.PolicyNumber = policyNumber;
    this.EffectiveDate = effectiveDate;
    this.TransactionAmount = transactionAmount;
    this.OptionalErrorMessage = optionalErrorMessage;
    this.RowNumber = rowNumber;
  }

  public PoliciesStatus(
    int controlNo,
    int quoteId,
    DateTime dateProcessed,
    DateTime? effectiveDate,
    string insuredName,
    string policyNumber,
    Decimal transactionAmount,
    int rowNumber,
    bool? insertSuccessful)
  {
    this.ControlNo = controlNo;
    this.QuoteId = quoteId;
    this.DateProcessed = dateProcessed;
    this.EffectiveDate = effectiveDate;
    this.InsuredName = insuredName;
    this.PolicyNumber = policyNumber;
    this.TransactionAmount = transactionAmount;
    this.RowNumber = rowNumber;
    this.InsertSuccessful = insertSuccessful;
  }

  public int ControlNo { get; }

  public int QuoteId { get; }

  public string PolicyNumber { get; }

  public string InsuredName { get; }

  public Decimal TransactionAmount { get; }

  public DateTime DateProcessed { get; }

  public DateTime? EffectiveDate { get; }

  public int RowNumber { get; }

  public string OptionalErrorMessage { get; }

  public bool? InsertSuccessful { get; }
}
