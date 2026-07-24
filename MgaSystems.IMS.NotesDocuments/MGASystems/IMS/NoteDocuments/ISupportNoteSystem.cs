// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.ISupportNoteSystem
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public interface ISupportNoteSystem : IRecreatableEntity
{
  bool CanCreateNewNote { get; }

  event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  delegate void EntityInfoChangedEventHandler(object sender, EventArgs e);
}
