// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValue
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

[Serializable]
internal class AppliedGridValue
{
  private int invoiceNumber;
  private int chargeCode;
  private Guid companyLineGuid;
  private Decimal arApplied;
  private Decimal exApplied;
  private Decimal uaApplied;
  private int controlNumber;

  public AppliedGridValue(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal arApplied,
    Decimal exApplied,
    Decimal uaApplied,
    int controlNumber)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
    this.arApplied = arApplied;
    this.exApplied = exApplied;
    this.uaApplied = uaApplied;
    this.controlNumber = controlNumber;
  }

  public int InvoiceNumber
  {
    get => this.invoiceNumber;
    set => this.invoiceNumber = value;
  }

  public int ChargeCode
  {
    get => this.chargeCode;
    set => this.chargeCode = value;
  }

  public Guid CompanyLineGuid
  {
    get => this.companyLineGuid;
    set => this.companyLineGuid = value;
  }

  public Decimal ArApplied
  {
    get => this.arApplied;
    set => this.arApplied = value;
  }

  public Decimal ExApplied
  {
    get => this.exApplied;
    set => this.exApplied = value;
  }

  public Decimal UaApplied
  {
    get => this.uaApplied;
    set => this.uaApplied = value;
  }

  public int ControlNumber
  {
    get => this.controlNumber;
    set => this.controlNumber = value;
  }
}
