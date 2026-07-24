// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Serialization.PreferenceException
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.Serialization;

[Serializable]
public class PreferenceException : InvalidOperationException
{
  public PreferenceException(string message)
    : base(message)
  {
  }

  public PreferenceException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected PreferenceException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }

  public PreferenceException()
  {
  }
}
