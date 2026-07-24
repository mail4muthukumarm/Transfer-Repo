// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.ClaimReceivableValueCollection
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Serializable]
public class ClaimReceivableValueCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public bool ItemExists(int claimid, int uaExpenseId, int resPayId)
  {
    bool flag = false;
    foreach (ClaimReceivableValue claimReceivableValue in (CollectionBase) this)
    {
      if (claimReceivableValue.ClaimId == claimid && claimReceivableValue.UAExpenseId == uaExpenseId && claimReceivableValue.ResPayId == resPayId)
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  public ClaimReceivableValue GetItem(int claimid, int uaExpenseId, int resPayId)
  {
    ClaimReceivableValue claimReceivableValue1 = (ClaimReceivableValue) null;
    foreach (ClaimReceivableValue claimReceivableValue2 in (CollectionBase) this)
    {
      if (claimReceivableValue2.ClaimId == claimid && claimReceivableValue2.UAExpenseId == uaExpenseId && claimReceivableValue2.ResPayId == resPayId)
      {
        claimReceivableValue1 = claimReceivableValue2;
        break;
      }
    }
    return claimReceivableValue1;
  }

  public Decimal GetApAppliedSum(int claimid, int uaExpenseId, int resPayId)
  {
    Decimal apAppliedSum = 0M;
    foreach (ClaimReceivableValue claimReceivableValue in (CollectionBase) this)
    {
      if (claimReceivableValue.ClaimId == claimid && claimReceivableValue.UAExpenseId == uaExpenseId && claimReceivableValue.ResPayId == resPayId)
        apAppliedSum += claimReceivableValue.Amount;
    }
    return apAppliedSum;
  }

  public ClaimReceivableValue this[int index] => (ClaimReceivableValue) this.List[index];

  public int IndexOf(ClaimReceivableValue value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, ClaimReceivableValue value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(ClaimReceivableValue value) => this.Contains(value);

  public void CopyTo(ClaimReceivableValueCollection detailCollection, int index)
  {
  }

  public void CopyTo(ClaimReceivableValueCollection detailCollection)
  {
    foreach (ClaimReceivableValue claimReceivableValue in (CollectionBase) this)
      detailCollection.Add(new ClaimReceivableValue(claimReceivableValue.ClaimId, claimReceivableValue.UAExpenseId, claimReceivableValue.ResPayId, claimReceivableValue.Amount));
  }

  protected override void OnInsertComplete(int index, object value)
  {
    base.OnInsertComplete(index, value);
    if (this.ListChanged == null)
      return;
    this.ListChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
  }

  protected override void OnRemoveComplete(int index, object value)
  {
    base.OnRemoveComplete(index, value);
    if (this.ListChanged == null)
      return;
    this.ListChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
  }

  public void AddIndex(PropertyDescriptor property)
  {
  }

  public bool AllowNew => false;

  public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
  {
  }

  public PropertyDescriptor SortProperty => (PropertyDescriptor) null;

  public int Find(PropertyDescriptor property, object key) => 0;

  public bool SupportsSorting => false;

  public bool IsSorted => false;

  public bool AllowRemove => true;

  public bool SupportsSearching => false;

  public ListSortDirection SortDirection => ListSortDirection.Ascending;

  public event ListChangedEventHandler ListChanged;

  public bool SupportsChangeNotification => true;

  public void RemoveSort()
  {
  }

  public object AddNew() => (object) null;

  public bool AllowEdit => false;

  public void RemoveIndex(PropertyDescriptor property)
  {
  }

  public void Add(ClaimReceivableValue appliedGridValue)
  {
    this.List.Add((object) appliedGridValue);
  }

  public void Add(UltraGridRow rowObject)
  {
    int claimId = int.Parse(rowObject.Cells["claimId"].Value.ToString(), NumberStyles.Any);
    int uaExpenseId = -1;
    if (((KeyedSubObjectsCollectionBase) ((GridItemBase) rowObject).Band.Columns).Exists("UAExpenseId"))
      uaExpenseId = int.Parse(rowObject.Cells["UAExpenseId"].Value.ToString(), NumberStyles.Any);
    int resPayId = -1;
    if (((KeyedSubObjectsCollectionBase) ((GridItemBase) rowObject).Band.Columns).Exists("ResPayId"))
      resPayId = int.Parse(rowObject.Cells["ResPayId"].Value.ToString(), NumberStyles.Any);
    Decimal amount = 0M;
    if (rowObject.Cells["ClaimARApplied"].Value != null)
      amount = Decimal.Parse(rowObject.Cells["ClaimARApplied"].Value.ToString(), NumberStyles.Any);
    this.List.Add((object) new ClaimReceivableValue(claimId, uaExpenseId, resPayId, amount));
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new Exception($"The system could not find an applied grid value object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }
}
