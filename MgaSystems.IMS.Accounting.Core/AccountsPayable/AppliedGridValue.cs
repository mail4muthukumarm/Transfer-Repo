// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValue
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

[Serializable]
public class AppliedGridValue
{
  private Decimal apApplied;
  private int chargeCode;
  private Guid companyLineGuid;
  private int controlNumber;
  private Guid entityGuid;
  private int invoiceNumber;
  [OptionalField]
  private Decimal? grossPayable;

  public Decimal ApApplied
  {
    get => this.apApplied;
    set => this.apApplied = value;
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

  public int ControlNumber
  {
    get => this.controlNumber;
    set => this.controlNumber = value;
  }

  public Guid EntityGuid
  {
    get => this.entityGuid;
    set => this.entityGuid = value;
  }

  public Decimal? GrossPayable
  {
    get => this.grossPayable;
    set => this.grossPayable = value;
  }

  public int InvoiceNumber
  {
    get => this.invoiceNumber;
    set => this.invoiceNumber = value;
  }

  public AppliedGridValue(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal apApplied,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable = null)
  {
    this.ApApplied = apApplied;
    this.ChargeCode = chargeCode;
    this.CompanyLineGuid = companyLineGuid;
    this.ControlNumber = controlNumber;
    this.EntityGuid = entityGuid;
    this.GrossPayable = grossPayable;
    this.InvoiceNumber = invoiceNumber;
  }
}
