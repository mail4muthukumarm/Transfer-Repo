// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.InterCompanyTransferCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class InterCompanyTransferCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public virtual InterCompanyTransfer this[int index] => (InterCompanyTransfer) this.List[index];

  public int IndexOf(InterCompanyTransfer value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, InterCompanyTransfer value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(InterCompanyTransfer value) => this.Contains(value);

  public void CopyTo(
    InterCompanyTransferCollection interCompanyTransferCollection,
    int index)
  {
  }

  public void CopyTo(
    InterCompanyTransferCollection interCompanyTransferCollection)
  {
    foreach (InterCompanyTransfer interCompanyTransfer in (CollectionBase) this)
    {
      bool isCredit = interCompanyTransfer.TransactionType.ToUpper() == "CREDIT";
      interCompanyTransferCollection.Add(new InterCompanyTransfer(interCompanyTransfer.GlAccountId, interCompanyTransfer.GlAccountShortName, interCompanyTransfer.Comments, interCompanyTransfer.Amount, interCompanyTransfer.CostCenterId, interCompanyTransfer.CostCenterName, isCredit));
    }
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

  public void Add(InterCompanyTransfer interCompanyTransfer)
  {
    this.List.Add((object) interCompanyTransfer);
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new ObjectNotFoundException($"The system could not find a inter-company transfer object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }

  public Decimal InterCompanyTransferTotal()
  {
    Decimal num = 0M;
    foreach (InterCompanyTransfer interCompanyTransfer in (CollectionBase) this)
      num += interCompanyTransfer.Amount;
    return num;
  }

  public void Replace(int index, InterCompanyTransfer transferObject)
  {
    this[index].Copy(transferObject);
    if (this.ListChanged == null)
      return;
    this.ListChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
  }

  public int GetInterCompanyTransferObjectIndex(
    int glAccountId,
    string glAccountShortName,
    string comments,
    Decimal amount)
  {
    int transferObjectIndex = -1;
    for (int index = 0; index < this.Count; ++index)
    {
      InterCompanyTransfer interCompanyTransfer = this[index];
      if (interCompanyTransfer.GlAccountId == glAccountId && interCompanyTransfer.GlAccountShortName == glAccountShortName && interCompanyTransfer.Amount == amount && interCompanyTransfer.Comments == comments)
      {
        transferObjectIndex = index;
        break;
      }
    }
    return transferObjectIndex;
  }
}
