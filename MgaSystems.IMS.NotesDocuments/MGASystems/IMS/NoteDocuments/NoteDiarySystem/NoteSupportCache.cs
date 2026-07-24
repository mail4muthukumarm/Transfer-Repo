// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

public class NoteSupportCache : ISupportNoteSystem
{
  private bool _canCreateNewNote;
  private bool _canReCreateEntity;
  private Guid _entityGUID;
  private string _entityName;
  private string _friendlyEntityName;
  private string _recreateTypeName;
  private bool _hasControlGuid;
  private Guid _controlGuid;

  public NoteSupportCache(
    Guid entityGUID,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGuid,
    Guid controlGuid)
  {
    this._canCreateNewNote = true;
    this._canReCreateEntity = true;
    this._entityGUID = entityGUID;
    this._entityName = entityName;
    this._friendlyEntityName = friendlyEntityName;
    this._recreateTypeName = recreateTypeName;
    this._hasControlGuid = hasControlGuid;
    this._controlGuid = controlGuid;
  }

  public NoteSupportCache()
  {
    this._entityGUID = Guid.Empty;
    this._entityName = string.Empty;
    this._friendlyEntityName = string.Empty;
    this._recreateTypeName = string.Empty;
    this._controlGuid = Guid.Empty;
  }

  public NoteSupportCache(ISupportNoteSystem noteSupport)
  {
    ISupportNoteSystem supportNoteSystem = noteSupport;
    this._canCreateNewNote = supportNoteSystem.CanCreateNewNote;
    this._canReCreateEntity = supportNoteSystem.CanReCreateEntity;
    this._entityGUID = supportNoteSystem.EntityGuid;
    this._entityName = supportNoteSystem.EntityName;
    this._friendlyEntityName = supportNoteSystem.FriendlyEntityName;
    this._recreateTypeName = supportNoteSystem.RecreateTypeName;
    this._hasControlGuid = supportNoteSystem.HasControlGUID;
    if (supportNoteSystem.HasControlGUID)
      this._controlGuid = supportNoteSystem.ControlGUID;
  }

  Guid IRecreatableEntity.ControlGUID => this._controlGuid;

  bool IRecreatableEntity.HasControlGUID => this._hasControlGuid;

  string IRecreatableEntity.EntityName => this._entityName;

  string IRecreatableEntity.FriendlyEntityName => this._friendlyEntityName;

  string IRecreatableEntity.RecreateTypeName => this._recreateTypeName;

  Guid IRecreatableEntity.EntityGUID => this._entityGUID;

  public bool CanCreateNewNote => this._canCreateNewNote;

  bool IRecreatableEntity.CanReCreateEntity => this._canReCreateEntity;

  [EditorBrowsable(EditorBrowsableState.Never)]
  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;
}
