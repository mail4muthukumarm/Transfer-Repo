// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.VerifyFile
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Security.Cryptography;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class VerifyFile
{
  public static bool ValidUploadHash(byte[] localFile, byte[] dbFile)
  {
    return string.Compare(Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(localFile)), Convert.ToBase64String(dbFile), true) == 0;
  }
}
