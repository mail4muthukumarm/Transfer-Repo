// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

[Serializable]
public class AppliedGridValueCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable,
  IEnumerable<AppliedGridValue>
{
  public AppliedGridValue this[int index] => (AppliedGridValue) this.List[index];

  public void Add(AppliedGridValue appliedGridValue)
  {
    if (appliedGridValue == null)
      throw new ArgumentNullException(nameof (appliedGridValue));
    this.List.Add((object) appliedGridValue);
  }

  public void Add(UltraGridRow row)
  {
    Decimal apApplied = row != null ? row.Field<Decimal?>(formTransactionBuilder.ArApGridColumnKeys.ApApplied).GetValueOrDefault() : throw new ArgumentNullException(nameof (row));
    int chargeCode = row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.ChargeCode);
    Guid result1;
    Guid.TryParse(row.Field<string>(formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid), out result1);
    int controlNumber = row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.ControlNum);
    Guid result2;
    Guid.TryParse(row.Field<string>(formTransactionBuilder.ArApGridColumnKeys.PayeeGuid), out result2);
    Decimal num = row.Field<Decimal>(formTransactionBuilder.ArApGridColumnKeys.GrossPayable);
    this.Add(row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber), chargeCode, result1, apApplied, controlNumber, result2, new Decimal?(num));
  }

  public void Add(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal apApplied,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable)
  {
    this.List.Add((object) new AppliedGridValue(invoiceNumber, chargeCode, companyLineGuid, apApplied, controlNumber, entityGuid, grossPayable));
  }

  public Decimal GetApAppliedSum(int controlNumber)
  {
    return this.Where<AppliedGridValue>((Func<AppliedGridValue, bool>) (i => i.ControlNumber == controlNumber)).Sum<AppliedGridValue>((Func<AppliedGridValue, Decimal>) (i => i.ApApplied));
  }

  public AppliedGridValue GetItem(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable = null)
  {
    return this.GetMatch(invoiceNumber, chargeCode, companyLineGuid, controlNumber, entityGuid, grossPayable);
  }

  public bool ItemExists(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable = null)
  {
    return this.GetMatch(invoiceNumber, chargeCode, companyLineGuid, controlNumber, entityGuid, grossPayable) != null;
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new ObjectNotFoundException($"The system could not find an applied grid value object at index {index}.");
    this.List.RemoveAt(index);
  }

  public bool TryGetItem(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable,
    out AppliedGridValue match)
  {
    match = this.GetMatch(invoiceNumber, chargeCode, companyLineGuid, controlNumber, entityGuid, grossPayable);
    return match != null;
  }

  public bool Contains(AppliedGridValue value) => this.List.Contains((object) value);

  public void CopyTo(AppliedGridValueCollection detailCollection, int index)
  {
    throw new NotImplementedException();
  }

  public void CopyTo(AppliedGridValueCollection detailCollection)
  {
    foreach (AppliedGridValue appliedGridValue in this)
      detailCollection.Add(new AppliedGridValue(appliedGridValue.InvoiceNumber, appliedGridValue.ChargeCode, appliedGridValue.CompanyLineGuid, appliedGridValue.ApApplied, appliedGridValue.ControlNumber, appliedGridValue.EntityGuid, appliedGridValue.GrossPayable));
  }

  public int IndexOf(AppliedGridValue value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, AppliedGridValue value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  protected override void OnInsertComplete(int index, object value)
  {
    base.OnInsertComplete(index, value);
    ListChangedEventHandler listChanged = this.ListChanged;
    if (listChanged == null)
      return;
    listChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
  }

  protected override void OnRemoveComplete(int index, object value)
  {
    base.OnRemoveComplete(index, value);
    ListChangedEventHandler listChanged = this.ListChanged;
    if (listChanged == null)
      return;
    listChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
  }

  public bool AllowEdit => false;

  public bool AllowNew => false;

  public bool AllowRemove => true;

  public bool IsSorted => false;

  public event ListChangedEventHandler ListChanged;

  public ListSortDirection SortDirection => ListSortDirection.Ascending;

  public PropertyDescriptor SortProperty => (PropertyDescriptor) null;

  public bool SupportsChangeNotification => true;

  public bool SupportsSearching => false;

  public bool SupportsSorting => false;

  public void AddIndex(PropertyDescriptor property) => throw new NotSupportedException();

  public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
  {
    throw new NotSupportedException();
  }

  public int Find(PropertyDescriptor property, object key) => 0;

  public void RemoveSort() => throw new NotSupportedException();

  public object AddNew() => (object) null;

  public void RemoveIndex(PropertyDescriptor property) => throw new NotSupportedException();

  public IEnumerator<AppliedGridValue> GetEnumerator()
  {
    for (int i = 0; i < this.Count; ++i)
      yield return this[i];
  }

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

  private AppliedGridValue GetMatch(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber,
    Guid entityGuid,
    Decimal? grossPayable)
  {
    AppliedGridValue[] array = this.Where<AppliedGridValue>((Func<AppliedGridValue, bool>) (i => i.InvoiceNumber == invoiceNumber && i.ChargeCode == chargeCode && i.ControlNumber == controlNumber && i.CompanyLineGuid == companyLineGuid && i.EntityGuid == entityGuid)).ToArray<AppliedGridValue>();
    return grossPayable.HasValue && ((IEnumerable<AppliedGridValue>) array).Any<AppliedGridValue>((Func<AppliedGridValue, bool>) (i => i.GrossPayable.HasValue)) ? ((IEnumerable<AppliedGridValue>) array).Where<AppliedGridValue>((Func<AppliedGridValue, bool>) (i => i.GrossPayable.HasValue)).FirstOrDefault<AppliedGridValue>((Func<AppliedGridValue, bool>) (i =>
    {
      Decimal? grossPayable1 = i.GrossPayable;
      Decimal? nullable = grossPayable;
      return grossPayable1.GetValueOrDefault() == nullable.GetValueOrDefault() & grossPayable1.HasValue == nullable.HasValue;
    })) : ((IEnumerable<AppliedGridValue>) array).FirstOrDefault<AppliedGridValue>();
  }
}
