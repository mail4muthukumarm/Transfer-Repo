// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.NotesFoundEventArgs
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

public sealed class NotesFoundEventArgs : EventArgs
{
  private DataTable _notesFound;
  private Guid _entityGuid;

  public NotesFoundEventArgs(DataTable notesFound, Guid entityGuid)
  {
    this._notesFound = notesFound;
    this._entityGuid = entityGuid;
  }

  public Guid EntityGuid => this._entityGuid;

  public DataTable NotesFound => this._notesFound;
}
