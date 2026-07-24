// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.ExpenseDetailEnumerator
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class ExpenseDetailEnumerator : IEnumerator
{
  private int position;
  private BankDepositDetails _BankDepositDetails;

  internal ExpenseDetailEnumerator(BankDepositDetails ExpenseDetails)
  {
    this.position = -1;
    this._BankDepositDetails = ExpenseDetails;
  }

  public object Current
  {
    get
    {
      return (object) (BankDepositDetail) this._BankDepositDetails._BankDepositDetails.GetByIndex(this.position);
    }
  }

  public bool MoveNext()
  {
    bool flag;
    if (this.position < this._BankDepositDetails._BankDepositDetails.Count - 1)
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this.position) + 1;
      local = num;
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  public void Reset() => this.position = -1;
}
