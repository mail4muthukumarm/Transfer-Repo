// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DataGridColumnInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data.Binding;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public abstract class DataGridColumnInfo : BindingObject
{
  public string ColumnKey { get; set; }

  public string Header { get; set; }

  [NotificationProperty]
  public virtual bool Hidden { get; set; }

  public int Position { get; set; }

  public DataGridColumnInfo(string colKey, bool isHidden, string colHeader, int pos)
  {
    this.ColumnKey = colKey;
    this.Hidden = isHidden;
    this.Header = colHeader;
    this.Position = pos;
  }

  public static DataGridColumnInfo Allocate(
    string colKey,
    bool isHidden,
    string colHeader,
    int pos)
  {
    return NotifyProxyTypeManager.Allocate<DataGridColumnInfo>(new object[4]
    {
      (object) colKey,
      (object) isHidden,
      (object) colHeader,
      (object) pos
    });
  }

  public static ObservableCollection<DataGridColumnInfo> CreateNewListForChooser(
    ObservableCollection<DataGridColumnInfo> colCollection)
  {
    ObservableCollection<DataGridColumnInfo> newListForChooser = new ObservableCollection<DataGridColumnInfo>();
    try
    {
      foreach (DataGridColumnInfo col in (Collection<DataGridColumnInfo>) colCollection)
        newListForChooser.Add(DataGridColumnInfo.Allocate(col.ColumnKey, col.Hidden, col.Header, col.Position));
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
    return newListForChooser;
  }
}
