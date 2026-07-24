// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentBoundContext
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class DocumentBoundContext
{
  public Guid? ControlGuid { get; }

  public Guid DocumentGuid { get; }

  public Guid EntityGuid { get; }

  public string EntityName { get; }

  public string FriendlyEntityName { get; }

  public string RecreateTypeName { get; }

  public DocumentBoundContext(
    Guid documentGuid,
    Guid entityGuid,
    string recreateTypeName,
    string entityName,
    string friendlyEntityName,
    Guid? controlGuid)
  {
    this.DocumentGuid = documentGuid;
    this.EntityGuid = entityGuid;
    this.RecreateTypeName = recreateTypeName;
    this.EntityName = entityName;
    this.FriendlyEntityName = friendlyEntityName;
    this.ControlGuid = controlGuid;
  }
}
