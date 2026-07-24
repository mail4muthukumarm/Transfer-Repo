// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.CollectionPage`1
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[DefaultMember("Item")]
public class CollectionPage<T> : ICollectionPage<T>
{
  public CollectionPage() => this.CurrentPage = (IList<T>) new List<T>();

  public CollectionPage(IList<T> currentPage) => this.CurrentPage = currentPage;

  public IList<T> CurrentPage { get; set; }

  int IList<T>.IndexOf(T item) => this.CurrentPage.IndexOf(item);

  void IList<T>.Insert(int index, T item) => this.CurrentPage.Insert(index, item);

  void IList<T>.RemoveAt(int index) => this.CurrentPage.RemoveAt(index);

  T IList<T>.this[int index]
  {
    get => this.CurrentPage[index];
    set => this.CurrentPage[index] = value;
  }

  void ICollection<T>.Add(T item) => this.CurrentPage.Add(item);

  void ICollection<T>.Clear() => this.CurrentPage.Clear();

  bool ICollection<T>.Contains(T item) => this.CurrentPage.Contains(item);

  void ICollection<T>.CopyTo(T[] array, int arrayIndex)
  {
    this.CurrentPage.CopyTo(array, arrayIndex);
  }

  int ICollection<T>.Count => this.CurrentPage.Count;

  bool ICollection<T>.IsReadOnly => this.CurrentPage.IsReadOnly;

  bool ICollection<T>.Remove(T item) => this.CurrentPage.Remove(item);

  IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.CurrentPage.GetEnumerator();

  IEnumerator IEnumerable.GetSimpleEnumerator() => (IEnumerator) this.CurrentPage.GetEnumerator();

  public IDictionary<string, object> AdditionalData { get; set; }
}
