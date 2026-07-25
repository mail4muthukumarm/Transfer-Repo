// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.InstallmentInvoiceItem
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies.InstallmentBilling;

public class InstallmentInvoiceItem
{
  private string _description;
  private int? _invoicenum;
  private DateTime _dueDate;

  public int? InvoiceNum => this._invoicenum;

  public DateTime DueDate => this._dueDate;

  public InstallmentInvoiceItem(int? invoiceNum, string description, DateTime dueDate)
  {
    this._invoicenum = invoiceNum;
    this._description = description;
    this._dueDate = dueDate;
  }

  public override string ToString() => this._description;
}
