// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentMissingException
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System;

#nullable disable
namespace MGASystems.IMS.DocumentStorage;

[Serializable]
public class DocumentMissingException : Exception
{
  public DocumentMissingException()
  {
  }

  public DocumentMissingException(string message)
    : base(message)
  {
  }

  public DocumentMissingException(string message, Exception innerException)
    : base(message, innerException)
  {
  }
}
