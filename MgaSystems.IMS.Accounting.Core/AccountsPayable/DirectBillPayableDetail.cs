// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillPayableDetail
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillPayableDetail
{
  private int invoiceNumber;
  private int chargeCode;
  private Guid companyLineGuid;
  private Decimal apApplied;

  public DirectBillPayableDetail(int invoiceNumber, int chargeCode, Guid companyLineGuid)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
  }

  public DirectBillPayableDetail(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal apApplied)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
    this.apApplied = apApplied;
  }

  public int InvoiceNumber => this.invoiceNumber;

  public int ChargeCode => this.chargeCode;

  public Guid CompanyLineGuid => this.companyLineGuid;

  public Decimal ApApplied
  {
    get => this.apApplied;
    set => this.apApplied = value;
  }
}
