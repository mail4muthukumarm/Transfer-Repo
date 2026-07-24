// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseException
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.DataAccess;

[Serializable]
public sealed class DatabaseException : Exception
{
  public DatabaseException(string message)
    : base(message)
  {
  }

  protected DatabaseException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected DatabaseException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }

  protected DatabaseException()
  {
  }
}
