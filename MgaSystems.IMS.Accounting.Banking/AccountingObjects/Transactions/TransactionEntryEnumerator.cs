// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions.TransactionEntryEnumerator
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class TransactionEntryEnumerator : IEnumerator
{
  private int position;
  private TransactionEntries _TransactionEntries;

  public TransactionEntryEnumerator(TransactionEntries TransactionEntries)
  {
    this.position = -1;
    this._TransactionEntries = TransactionEntries;
  }

  public object Current
  {
    get
    {
      return (object) (TransactionEntry) this._TransactionEntries._TransactionEntries.GetByIndex(this.position);
    }
  }

  public bool MoveNext()
  {
    bool flag;
    if (this.position < this._TransactionEntries._TransactionEntries.Count - 1)
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
