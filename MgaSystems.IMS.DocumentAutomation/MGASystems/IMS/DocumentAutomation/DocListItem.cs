// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocListItem
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System;
using System.IO;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class DocListItem
{
  private Guid _documentStoreGuid;
  private string _document;
  private string _fileName;
  private string[] _fileNames;
  private string _description;
  private string _attachmentFileName;
  private string _folderName;

  public DocListItem(string fileName)
  {
    this._documentStoreGuid = Guid.Empty;
    this._document = string.Empty;
    this._fileName = string.Empty;
    this._fileNames = (string[]) null;
    this._fileName = fileName;
    this._attachmentFileName = Path.GetFileName(fileName);
  }

  public DocListItem(Guid documentStoreGuid, string document, string attachmentFileName)
  {
    this._documentStoreGuid = Guid.Empty;
    this._document = string.Empty;
    this._fileName = string.Empty;
    this._fileNames = (string[]) null;
    this._documentStoreGuid = documentStoreGuid;
    this._document = document;
    this._attachmentFileName = attachmentFileName;
  }

  public DocListItem(
    Guid documentStoreGuid,
    string document,
    string attachmentFileName,
    string folderName)
  {
    this._documentStoreGuid = Guid.Empty;
    this._document = string.Empty;
    this._fileName = string.Empty;
    this._fileNames = (string[]) null;
    this._documentStoreGuid = documentStoreGuid;
    this._document = document;
    this._attachmentFileName = attachmentFileName;
    this._folderName = folderName;
  }

  public DocListItem(string[] fileNames, string description)
  {
    this._documentStoreGuid = Guid.Empty;
    this._document = string.Empty;
    this._fileName = string.Empty;
    this._fileNames = (string[]) null;
    this._fileNames = fileNames != null && fileNames.Length != 0 ? fileNames : throw new InvalidOperationException("fileNames can not be null");
    this._description = description;
    this._attachmentFileName = "N/A";
  }

  public bool Editable => this._fileNames != null && this._fileNames.Length > 0;

  public string AttachmentFileName => this._attachmentFileName;

  public string Description => this._description;

  public Guid DocumentStoreGuid => this._documentStoreGuid;

  public string Document => this._document;

  public string Filename => this._fileName;

  public string[] FileNames => this._fileNames;

  public string FolderName => this._folderName;

  public override string ToString()
  {
    return string.IsNullOrEmpty(this._description) ? (string.IsNullOrEmpty(this._document) ? Path.GetFileName(this._fileName) : this._document) : this._description;
  }
}
