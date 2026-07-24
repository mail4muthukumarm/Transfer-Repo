// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.ReplacePDFInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public abstract class ReplacePDFInfo : ValidatingBindingObject
{
  [NotificationProperty]
  public virtual string SourceFile { get; set; }

  [NotificationProperty]
  public virtual Guid? SourceFileGuid { get; set; }

  [NotificationProperty]
  public virtual string OutsideFile { get; set; }

  [NotificationProperty]
  public virtual Guid? OutsideFileGuid { get; set; }

  [NotificationProperty]
  public virtual int SourceFilePageCount { get; set; }

  [NotificationProperty]
  public virtual int ReplacePageStart { get; set; }

  [NotificationProperty]
  public virtual int ReplacePageEnd { get; set; }

  [NotificationProperty]
  public virtual bool CanChooseLocalFiles { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<SelectedDocInfo> DocumentToInsertList { get; set; }

  public static ReplacePDFInfo Create(List<SelectedDocInfo> selectedDocInfo)
  {
    return NotifyProxyTypeManager.Allocate<ReplacePDFInfo>(new object[1]
    {
      (object) selectedDocInfo
    });
  }

  public ReplacePDFInfo(List<SelectedDocInfo> selectedDocInfo)
  {
    this.DocumentToInsertList = new ObservableCollection<SelectedDocInfo>();
    this.SourceFile = selectedDocInfo[0].DocumentName;
    this.SourceFileGuid = new Guid?(selectedDocInfo[0].DocumentGuid);
    try
    {
      foreach (SelectedDocInfo selectedDocInfo1 in selectedDocInfo.Skip<SelectedDocInfo>(1))
        this.DocumentToInsertList.Add(new SelectedDocInfo()
        {
          DocumentName = selectedDocInfo1.DocumentName,
          DocumentGuid = selectedDocInfo1.DocumentGuid
        });
    }
    finally
    {
      IEnumerator<SelectedDocInfo> enumerator;
      enumerator?.Dispose();
    }
    this.CanChooseLocalFiles = this.DocumentToInsertList.Count == 0;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((BindingObject) this).OnPropertyChanged(propertyName);
    if (Operators.CompareString(propertyName, "SourceFileGuid", false) != 0)
      return;
    Guid? sourceFileGuid = this.SourceFileGuid;
    if (!sourceFileGuid.HasValue)
      return;
    sourceFileGuid = this.SourceFileGuid;
    this.SourceFilePageCount = DocumentManager.GetPageCount(sourceFileGuid.Value);
  }

  public bool IsValid()
  {
    return this.ReplacePageStart >= 1 & this.ReplacePageEnd <= this.SourceFilePageCount && this.DocumentToInsertList.Count > 0;
  }

  public List<string> GetSplitList()
  {
    List<string> splitList = new List<string>();
    if (this.ReplacePageStart == 1)
    {
      splitList.Add($"1-{this.ReplacePageEnd}");
      splitList.Add($"{this.ReplacePageEnd + 1}-{this.SourceFilePageCount}");
    }
    else if (this.ReplacePageEnd == this.SourceFilePageCount)
    {
      splitList.Add($"1-{this.ReplacePageStart - 1}");
      splitList.Add($"{this.ReplacePageStart}-{this.SourceFilePageCount}");
    }
    else
    {
      splitList.Add($"1-{this.ReplacePageStart - 1}");
      splitList.Add($"{this.ReplacePageStart}-{this.ReplacePageEnd}");
      splitList.Add($"{this.ReplacePageEnd + 1}-{this.SourceFilePageCount}");
    }
    return splitList;
  }
}
