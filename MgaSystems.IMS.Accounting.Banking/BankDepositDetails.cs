// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankDepositDetails
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[EditorBrowsable(EditorBrowsableState.Never)]
[DefaultProperty("Item")]
[Serializable]
internal sealed class BankDepositDetails : IEnumerable
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal SortedList _BankDepositDetails;

  internal BankDepositDetail this[int index]
  {
    get
    {
      return this._BankDepositDetails == null || this._BankDepositDetails.Count == 0 ? (BankDepositDetail) null : (BankDepositDetail) this._BankDepositDetails.GetByIndex(index);
    }
  }

  [Browsable(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal event BankDepositDetails.ExpenseCopyEventDelegate CopyComplete;

  internal BankDepositDetails() => this._BankDepositDetails = new SortedList();

  [EditorBrowsable(EditorBrowsableState.Never)]
  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new ExpenseDetailEnumerator(this);

  internal void AddBankDepositDetail(string Key, BankDepositDetail BankDepositDetail)
  {
    this._BankDepositDetails.Add((object) Key, (object) BankDepositDetail);
  }

  internal void RemoveBankDepositDetail(string key)
  {
    this._BankDepositDetails.Remove((object) key);
  }

  internal string GetItemKey(int index) => this._BankDepositDetails.GetKeyList()[index].ToString();

  internal int Count() => this._BankDepositDetails.Count;

  internal void Clear() => this._BankDepositDetails.Clear();

  internal Decimal ChecksTotal()
  {
    Decimal num;
    if (this._BankDepositDetails.Count == 0)
    {
      num = 0M;
    }
    else
    {
      Decimal d1;
      int index;
      for (; index < this._BankDepositDetails.Count; ++index)
        d1 = Decimal.Add(d1, ((BankDepositDetail) this._BankDepositDetails.GetByIndex(index)).CheckAmount);
      num = d1;
    }
    return num;
  }

  internal BankDepositDetail[] ToArray()
  {
    BankDepositDetail[] array = new BankDepositDetail[this.Count() + 1];
    this._BankDepositDetails.CopyTo((Array) array, 0);
    return array;
  }

  [Browsable(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal delegate void ExpenseCopyEventDelegate(object sender, EventArgs e);
}
