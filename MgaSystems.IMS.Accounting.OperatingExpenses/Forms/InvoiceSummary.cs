// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.InvoiceSummary
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

internal class InvoiceSummary
{
  private string _invoiceNum;
  private string _policyNum;
  private string _description;
  private Decimal _amount;

  public InvoiceSummary(string invoiceNum, string policyNum, string description, Decimal amount)
  {
    this._invoiceNum = invoiceNum;
    this._policyNum = policyNum;
    this._description = description;
    this._amount = amount;
  }

  public string InvoiceNum
  {
    get => this._invoiceNum;
    set => this._invoiceNum = value;
  }

  public string PolicyNum
  {
    get => this._policyNum;
    set => this._policyNum = value;
  }

  public string Description
  {
    get => this._description;
    set => this._description = value;
  }

  public Decimal Amount
  {
    get => this._amount;
    set => this._amount = value;
  }
}
