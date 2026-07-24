// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentFolderFilterAttribute
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class DocumentFolderFilterAttribute : Attribute
{
  private string _name;

  internal DocumentFolderFilterAttribute()
  {
  }

  public DocumentFolderFilterAttribute(string name) => this._name = name;

  public override bool Match(object obj) => obj is DocumentFolderFilterAttribute;

  internal string Name => this._name;
}
