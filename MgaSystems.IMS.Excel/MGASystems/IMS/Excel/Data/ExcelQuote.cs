// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.ExcelQuote
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;

#nullable disable
namespace MGASystems.IMS.Excel.Data;

public class ExcelQuote
{
  public ExcelQuoteCollection Parent { get; }

  public int ControlNumber { get; }

  public Guid QuoteGuid { get; }

  public Guid FactorSetGuid { get; }

  public string StateId { get; }

  public string LineName { get; }

  public DateTime DateCreated { get; }

  public Decimal Premium { get; }

  public string InsuredPolicyName { get; }

  public ExcelQuote(
    int controlNumber,
    Guid quoteGuid,
    Guid factorSetGuid,
    string stateId,
    string lineName,
    DateTime dateCreated,
    Decimal premium,
    string insuredPolicyName,
    ExcelQuoteCollection parent)
  {
    this.Parent = parent;
    this.ControlNumber = controlNumber;
    this.QuoteGuid = quoteGuid;
    this.FactorSetGuid = factorSetGuid;
    this.StateId = stateId;
    this.LineName = lineName;
    this.DateCreated = dateCreated;
    this.Premium = premium;
    this.InsuredPolicyName = insuredPolicyName;
  }
}
