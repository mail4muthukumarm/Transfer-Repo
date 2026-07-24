// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.DirectBillReceivableDetail
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

internal class DirectBillReceivableDetail
{
  private int invoiceNumber;
  private int chargeCode;
  private Guid companyLineGuid;
  private Decimal arApplied;
  private Decimal exchApplied;
  private Decimal unAcctApplied;

  internal DirectBillReceivableDetail(int invoiceNumber, int chargeCode, Guid companyLineGuid)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
  }

  internal DirectBillReceivableDetail(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal arApplied,
    Decimal exchApplied,
    Decimal unAcctApplied)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
    this.arApplied = arApplied;
    this.exchApplied = exchApplied;
    this.unAcctApplied = unAcctApplied;
  }

  internal int InvoiceNumber => this.invoiceNumber;

  internal int ChargeCode => this.chargeCode;

  internal Guid CompanyLineGuid => this.companyLineGuid;

  internal Decimal ArApplied
  {
    get => this.arApplied;
    set => this.arApplied = value;
  }

  internal Decimal ExchApplied
  {
    get => this.exchApplied;
    set => this.exchApplied = value;
  }

  internal Decimal UnAcctApplied
  {
    get => this.unAcctApplied;
    set => this.unAcctApplied = value;
  }
}
