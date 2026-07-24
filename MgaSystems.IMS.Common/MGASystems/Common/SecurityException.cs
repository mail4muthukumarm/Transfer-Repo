// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SecurityException
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common;

[Serializable]
public sealed class SecurityException : Exception
{
  public SecurityException()
  {
  }

  public SecurityException(string message)
    : base(message)
  {
  }

  public SecurityException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected SecurityException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
