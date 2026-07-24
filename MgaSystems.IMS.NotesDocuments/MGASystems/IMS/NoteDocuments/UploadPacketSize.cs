// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.UploadPacketSize
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using System.Data;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class UploadPacketSize
{
  public static int GetBufferLength(int documentLength)
  {
    int bufferLength = DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spUploadPacketSizeGet", new object[2]
    {
      (object) "@DocLength",
      (object) documentLength
    }).Field<int>("BufferLength");
    if (bufferLength == 0)
      bufferLength = documentLength;
    return bufferLength;
  }
}
