// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NotInitializedException
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
[Serializable]
public class NotInitializedException : InvalidOperationException
{
  public override string Message
  {
    get => "Must call initialize on the NotesDocuments assembly prior to use.";
  }
}
