// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.NotificationCollection`1
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.Collections.ObjectModel;

#nullable disable
namespace MGASystems.IMS.Claims;

public class NotificationCollection<T> : Collection<T>
{
  public event EventHandler<EventArgs> CollectionChanged;

  protected void OnCollectionChanged()
  {
    if (this.CollectionChanged == null)
      return;
    this.CollectionChanged((object) this, EventArgs.Empty);
  }

  protected override void ClearItems()
  {
    base.ClearItems();
    this.OnCollectionChanged();
  }

  protected override void InsertItem(int index, T item)
  {
    if ((object) item == null)
      return;
    base.InsertItem(index, item);
    this.OnCollectionChanged();
  }

  protected override void RemoveItem(int index)
  {
    base.RemoveItem(index);
    this.OnCollectionChanged();
  }

  protected override void SetItem(int index, T item)
  {
    base.SetItem(index, item);
    this.OnCollectionChanged();
  }
}
