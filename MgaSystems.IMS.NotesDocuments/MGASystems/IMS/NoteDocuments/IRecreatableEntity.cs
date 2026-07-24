// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.IRecreatableEntity
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public interface IRecreatableEntity
{
  string EntityName { get; }

  Guid EntityGuid { get; }

  bool RecreateEntityInitialize(Guid entityGuid);

  string FriendlyEntityName { get; }

  string RecreateTypeName { get; }

  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
  bool CanReCreateEntity { get; }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  bool HasControlGUID { get; }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  Guid ControlGUID { get; }
}
