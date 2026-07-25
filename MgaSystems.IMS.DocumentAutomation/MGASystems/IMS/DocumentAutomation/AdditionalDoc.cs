// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AdditionalDoc
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class AdditionalDoc : BindingObject
{
  public Guid DocumentStoreGuid { get; set; }

  [NotificationProperty]
  public virtual string Description { get; set; }

  public string FileName { get; set; }

  public bool Editable { get; set; }

  public bool Added { get; set; }

  [NotificationProperty]
  public virtual string AttachmentFileName { get; set; }

  public object DocListItemTag
  {
    get => this._DocListItemTag;
    set => this._DocListItemTag = RuntimeHelpers.GetObjectValue(value);
  }

  [NotificationProperty]
  public virtual string FolderName { get; set; }

  public AdditionalDoc(
    Guid _docStoreGuid,
    string _descrip,
    string _fileName,
    bool _editable,
    bool _added,
    string _attachmentFileName,
    object _docListItemTag,
    string _folderName)
  {
    this.DocumentStoreGuid = _docStoreGuid;
    this.Description = _descrip;
    this.FileName = _fileName;
    this.Editable = _editable;
    this.Added = _added;
    this.AttachmentFileName = _attachmentFileName;
    this.DocListItemTag = RuntimeHelpers.GetObjectValue(_docListItemTag);
    this.FolderName = _folderName;
  }

  public static AdditionalDoc Create(
    Guid _docStoreGuid,
    string _descrip,
    string _fileName,
    bool _editable,
    bool _added,
    string _attachmentFileName,
    object _docListItemTag,
    string _folderName)
  {
    return NotifyProxyTypeManager.Allocate<AdditionalDoc>(new object[8]
    {
      (object) _docStoreGuid,
      (object) _descrip,
      (object) _fileName,
      (object) _editable,
      (object) _added,
      (object) _attachmentFileName,
      _docListItemTag,
      (object) _folderName
    });
  }

  public static List<DocListItem> GetDocItemList(Guid controlGuid)
  {
    List<DocListItem> docItemList = new List<DocListItem>();
    Guid[] associatedToEntity = DocumentManager.GetDocumentsAssociatedToEntity(controlGuid);
    int index = 0;
    while (index < associatedToEntity.Length)
    {
      Guid documentStoreGuid = associatedToEntity[index];
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetEntityAssociatedDocuments", new object[4]
      {
        (object) "@DocumentStoreGuid",
        (object) documentStoreGuid,
        (object) "@ControlGuid",
        null
      });
      docItemList.Add(new DocListItem(documentStoreGuid, dataTable.Rows[0].Field<string>("Document"), dataTable.Rows[0].Field<string>("FileName"), dataTable.Rows[0].Field<string>("FolderName")));
      checked { ++index; }
    }
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable("dbo.GetEntityAssociatedDocuments", new object[4]
      {
        (object) "@DocumentStoreGuid",
        null,
        (object) "@ControlGuid",
        (object) controlGuid
      }).Rows)
      {
        Guid documentStoreGuid = new Guid(row[0].ToString());
        docItemList.Add(new DocListItem(documentStoreGuid, row.Field<string>("Document"), row.Field<string>("FileName"), row.Field<string>("FolderName")));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return docItemList;
  }
}
