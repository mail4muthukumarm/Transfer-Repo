// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.InsertPDFInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.AsposeFacade;
using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public abstract class InsertPDFInfo : ValidatingBindingObject
{
  public int PageCount { get; set; }

  [NotificationProperty]
  public virtual string InputFile { get; set; }

  [NotificationProperty]
  public virtual Guid? InputFileGuid { get; set; }

  [NotificationProperty]
  public virtual string OutsideFile { get; set; }

  [NotificationProperty]
  public virtual Guid? OutsideFileGuid { get; set; }

  [NotificationProperty]
  public virtual int InsertLocation { get; set; }

  [NotificationProperty]
  public virtual int StartPage { get; set; }

  [NotificationProperty]
  public virtual int EndPage { get; set; }

  [NotificationProperty]
  public virtual int InputFilePageCount { get; set; }

  public bool OkToInsert { get; set; }

  public static InsertPDFInfo Create(string _inputFile, Guid? _inputFileGuid)
  {
    return NotifyProxyTypeManager.Allocate<InsertPDFInfo>(new object[2]
    {
      (object) _inputFile,
      (object) _inputFileGuid
    });
  }

  public InsertPDFInfo(string _inputFile, Guid? _inputFileGuid)
  {
    this.InputFile = _inputFile;
    this.InputFileGuid = _inputFileGuid;
    this.InsertLocation = 1;
    this.StartPage = 0;
    this.EndPage = 0;
    this.PageCount = 0;
    this.OkToInsert = false;
  }

  public static InsertPDFInfo Create(List<SelectedDocInfo> selectedDocInfo)
  {
    return NotifyProxyTypeManager.Allocate<InsertPDFInfo>(new object[1]
    {
      (object) selectedDocInfo
    });
  }

  public InsertPDFInfo(List<SelectedDocInfo> selectedDocInfo)
  {
    this.InsertLocation = 1;
    this.StartPage = 0;
    this.EndPage = 0;
    this.PageCount = 0;
    this.OkToInsert = false;
    this.InputFile = selectedDocInfo[0].DocumentName;
    this.InputFileGuid = new Guid?(selectedDocInfo[0].DocumentGuid);
    if (selectedDocInfo.Count != 2)
      return;
    this.OutsideFileGuid = new Guid?(selectedDocInfo[1].DocumentGuid);
    this.OutsideFile = selectedDocInfo[1].DocumentName;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((BindingObject) this).OnPropertyChanged(propertyName);
    if (Operators.CompareString(propertyName, "OutsideFile", false) == 0)
    {
      Guid? outsideFileGuid = this.OutsideFileGuid;
      if (!outsideFileGuid.HasValue && !string.IsNullOrEmpty(this.OutsideFile))
        this.PageCount = Utility.GetPDFPageCount(this.OutsideFile);
      outsideFileGuid = this.OutsideFileGuid;
      if (outsideFileGuid.HasValue)
      {
        outsideFileGuid = this.OutsideFileGuid;
        this.PageCount = DocumentManager.GetPageCount(outsideFileGuid.Value);
      }
      this.StartPage = 1;
      this.EndPage = this.PageCount;
    }
    else
    {
      if (Operators.CompareString(propertyName, "InputFileGuid", false) != 0)
        return;
      Guid? inputFileGuid = this.InputFileGuid;
      if (!inputFileGuid.HasValue)
        return;
      inputFileGuid = this.InputFileGuid;
      this.InputFilePageCount = DocumentManager.GetPageCount(inputFileGuid.Value);
    }
  }

  public bool IsValid()
  {
    return ((string.IsNullOrEmpty(this.OutsideFile) || this.InsertLocation < 0 ? 0 : (this.StartPage >= 1 ? 1 : 0)) & (this.EndPage <= this.PageCount ? 1 : 0)) != 0 && this.InsertLocation <= this.InputFilePageCount;
  }

  public void SwapFiles()
  {
    string inputFile = this.InputFile;
    Guid? inputFileGuid = this.InputFileGuid;
    this.InputFile = this.OutsideFile;
    this.InputFileGuid = this.OutsideFileGuid;
    this.OutsideFileGuid = inputFileGuid;
    this.OutsideFile = inputFile;
  }
}
