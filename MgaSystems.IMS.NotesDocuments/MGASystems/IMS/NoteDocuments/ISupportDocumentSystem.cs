// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.ISupportDocumentSystem
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public interface ISupportDocumentSystem : IRecreatableEntity
{
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  bool AllowAddNewDocument { get; }

  event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  delegate void EntityInfoChangedEventHandler(object sender, EventArgs e);
}
