// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.InvalidPermissionException
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Security;

[Serializable]
public sealed class InvalidPermissionException : Exception
{
  public InvalidPermissionException()
  {
  }

  public InvalidPermissionException(string message)
    : base(message)
  {
  }

  public InvalidPermissionException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  private InvalidPermissionException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
