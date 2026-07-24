// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentUploadingContext
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class DocumentUploadingContext
{
  private string _fileName;
  private Guid? _controlGuid;
  private Guid? _entityGuid;
  private int _folderID;

  public DocumentUploadingContext(string fileName)
    : this(-1, fileName, (ISupportDocumentSystem) null)
  {
  }

  public DocumentUploadingContext(string fileName, ISupportDocumentSystem docSupport)
    : this(-1, fileName, docSupport)
  {
  }

  public DocumentUploadingContext(int folderId, string fileName)
    : this(folderId, fileName, (ISupportDocumentSystem) null)
  {
  }

  public DocumentUploadingContext(int folderId, string fileName, ISupportDocumentSystem docSupport)
  {
    this._fileName = fileName;
    this._folderID = folderId;
    if (docSupport == null)
      return;
    if (docSupport.HasControlGUID)
      this._controlGuid = new Guid?(docSupport.ControlGUID);
    if (!docSupport.CanReCreateEntity)
      return;
    this._entityGuid = new Guid?(docSupport.EntityGuid);
  }

  public string FileName => this._fileName;

  public int FolderID => this._folderID;

  public Guid? ControlGuid => this._controlGuid;

  public Guid? EntityGuid => this._entityGuid;
}
