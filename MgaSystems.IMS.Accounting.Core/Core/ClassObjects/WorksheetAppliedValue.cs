// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.WorksheetAppliedValue
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class WorksheetAppliedValue
{
  private int invoiceNumber;
  private int chargeCode;
  private Guid companyLineGuid;
  private int controlNumber;

  public WorksheetAppliedValue(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber)
  {
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
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

  public int ControlNumber
  {
    get => this.controlNumber;
    set => this.controlNumber = value;
  }
}
