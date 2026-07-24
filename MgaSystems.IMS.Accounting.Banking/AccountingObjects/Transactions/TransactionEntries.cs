// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions.TransactionEntries
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;

[DefaultProperty("Item")]
[Serializable]
public sealed class TransactionEntries : IEnumerable
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal SortedList _TransactionEntries;

  internal TransactionEntry this[int index]
  {
    get
    {
      return this._TransactionEntries == null || this._TransactionEntries.Count == 0 ? (TransactionEntry) null : (TransactionEntry) this._TransactionEntries.GetByIndex(index);
    }
  }

  internal TransactionEntries() => this._TransactionEntries = new SortedList();

  [EditorBrowsable(EditorBrowsableState.Never)]
  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new TransactionEntryEnumerator(this);

  internal void AddTransactionEntry(string Key, TransactionEntry TransactionEntry)
  {
    this._TransactionEntries.Add((object) Key, (object) TransactionEntry);
  }

  internal void RemoveTransactionEntry(string key) => this._TransactionEntries.Remove((object) key);

  internal int Count() => this._TransactionEntries.Count;

  internal void Clear() => this._TransactionEntries.Clear();

  internal Decimal Sum()
  {
    Decimal num;
    if (this._TransactionEntries.Count == 0)
    {
      num = 0M;
    }
    else
    {
      Decimal d1;
      int index;
      for (; index < this._TransactionEntries.Count; ++index)
        d1 = Decimal.Add(d1, ((TransactionEntry) this._TransactionEntries.GetByIndex(index)).Amount);
      num = d1;
    }
    return num;
  }
}
