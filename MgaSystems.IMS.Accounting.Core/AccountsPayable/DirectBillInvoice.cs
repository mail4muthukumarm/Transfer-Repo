// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillInvoice
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillInvoice
{
  private int invoiceNum;
  private int officeInvoiceNum;
  private Guid payeeGuid;
  private int chargeCode;
  private Guid companyLineGuid;
  private int payeeAPAccount;
  private Decimal grossPayable;
  private Decimal proportionalAmountDue;
  private string insuredName;
  private string payeeName;

  public DirectBillInvoice(
    int InvoiceNumber,
    int OfficeInvoiceNumber,
    Guid PayeeGuid,
    int ChargeCode,
    Guid CompanyLineGuid,
    int PayableGlAccount,
    Decimal GrossPayable,
    string InsuredName,
    Decimal ProportionalAmountDue,
    string entityName)
  {
    this.invoiceNum = InvoiceNumber;
    this.officeInvoiceNum = OfficeInvoiceNumber;
    this.payeeGuid = PayeeGuid;
    this.chargeCode = ChargeCode;
    this.companyLineGuid = CompanyLineGuid;
    this.payeeAPAccount = PayableGlAccount;
    this.grossPayable = GrossPayable;
    this.insuredName = InsuredName;
    this.proportionalAmountDue = ProportionalAmountDue;
    this.payeeName = entityName;
  }

  public string PayeeName => this.payeeName;

  public int InvoiceNum
  {
    get => this.invoiceNum;
    set => this.invoiceNum = value;
  }

  public int OfficeInvoiceNum
  {
    get => this.officeInvoiceNum;
    set => this.officeInvoiceNum = value;
  }

  public Guid PayeeGuid
  {
    get => this.payeeGuid;
    set => this.payeeGuid = value;
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

  public int PayeeAPAccount => this.payeeAPAccount;

  public Decimal GrossPayable
  {
    get => this.grossPayable;
    set => this.grossPayable = value;
  }

  public Decimal ProportionalAmountDue => this.proportionalAmountDue;

  public string InsuredName => this.insuredName;

  public void CalculateProportionalAmountDue()
  {
  }
}
