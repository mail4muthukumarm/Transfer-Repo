// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.QueryEntityEventArgs
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class QueryEntityEventArgs : EventArgs
{
  private Guid _entityGUID;

  public QueryEntityEventArgs() => this._entityGUID = Guid.Empty;

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  public Guid EntityGUID
  {
    get => this._entityGUID;
    set => this._entityGUID = value;
  }
}
