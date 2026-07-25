// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.InvoiceItem
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System.Collections;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class InvoiceItem
{
  private int _invoiceNumber;
  private ArrayList _params;

  public int InvoiceNumber
  {
    get => this._invoiceNumber;
    set => this._invoiceNumber = value;
  }

  public ArrayList Params
  {
    get => this._params;
    set => this._params = value;
  }

  public InvoiceItem(int invoiceNumber, ArrayList @params)
  {
    this._params = new ArrayList();
    int num = @params.Count - 1;
    for (int index = 0; index <= num; ++index)
      this._params.Add(RuntimeHelpers.GetObjectValue(@params[index]));
    this._invoiceNumber = invoiceNumber;
  }

  public InvoiceItem(int invoiceNumber)
  {
    this._params = new ArrayList();
    this._invoiceNumber = invoiceNumber;
  }
}
