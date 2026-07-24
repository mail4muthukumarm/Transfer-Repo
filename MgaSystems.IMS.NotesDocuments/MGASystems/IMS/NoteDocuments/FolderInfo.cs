// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.FolderInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class FolderInfo
{
  private int _folderID;
  private int? _parentFolderID;
  private string _folderName;
  private bool _isDeletable;
  private Guid _secureResourceGuid;
  private int _childCount;

  public int ChildCount => this._childCount;

  public int FolderID => this._folderID;

  public int? ParentFolderID => this._parentFolderID;

  public string FolderName => this._folderName;

  public bool IsDeletable => this._isDeletable;

  public Guid SecureResourceGuid => this._secureResourceGuid;

  public FolderInfo(
    int folderID,
    int? parentFolderID,
    string folderName,
    bool isDeletable,
    Guid secureResourceGuid,
    int childCount)
  {
    this._folderID = folderID;
    this._parentFolderID = parentFolderID;
    this._folderName = folderName;
    this._isDeletable = isDeletable;
    this._secureResourceGuid = secureResourceGuid;
    this._childCount = childCount;
  }
}
