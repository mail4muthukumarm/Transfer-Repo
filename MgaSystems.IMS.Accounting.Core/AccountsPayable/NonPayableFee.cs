// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.NonPayableFee
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class NonPayableFee : IEditableObject
{
  private bool isSelected;
  private int quoteControlNumber;
  private int invoiceNumber;
  private int officeInvoiceNumber;
  private string policyNumber;
  private string insuredName;
  private int chargeCode;
  private Guid companyLineGuid;
  private Decimal amount;
  private int costCenterId;
  private bool editable_IsSelected;

  public NonPayableFee()
  {
  }

  public NonPayableFee(
    int quoteControlNumber,
    int invoiceNumber,
    int officeInvoiceNumber,
    string policyNumber,
    string insuredName,
    int chargeCode,
    Guid companyLineGuid,
    Decimal amount,
    int costCenter)
  {
    this.quoteControlNumber = quoteControlNumber;
    this.invoiceNumber = invoiceNumber;
    this.officeInvoiceNumber = officeInvoiceNumber;
    this.policyNumber = policyNumber;
    this.insuredName = insuredName;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
    this.amount = amount;
    this.isSelected = true;
    this.costCenterId = costCenter;
  }

  public int QuoteControlNumber
  {
    get => this.quoteControlNumber;
    set => this.quoteControlNumber = value;
  }

  public int CostCenterID
  {
    get => this.costCenterId;
    set => this.costCenterId = value;
  }

  public int InvoiceNumber
  {
    get => this.invoiceNumber;
    set => this.invoiceNumber = value;
  }

  public int OfficeInvoiceNumber
  {
    get => this.officeInvoiceNumber;
    set => this.officeInvoiceNumber = value;
  }

  public string PolicyNumber
  {
    get => this.policyNumber;
    set => this.policyNumber = value;
  }

  public string InsuredName
  {
    get => this.insuredName;
    set => this.insuredName = value;
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

  public Decimal Amount
  {
    get => this.amount;
    set => this.amount = value;
  }

  public bool IsSelected
  {
    get => this.isSelected;
    set => this.isSelected = value;
  }

  public void BeginEdit() => this.editable_IsSelected = this.isSelected;

  public void CancelEdit() => this.isSelected = this.editable_IsSelected;

  public void EndEdit()
  {
  }
}
