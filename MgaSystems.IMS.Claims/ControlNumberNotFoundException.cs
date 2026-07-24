// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ControlNumberNotFoundException
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Claims;

[Serializable]
public class ControlNumberNotFoundException : Exception
{
  public ControlNumberNotFoundException()
  {
  }

  public ControlNumberNotFoundException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  public ControlNumberNotFoundException(string message)
    : base(message)
  {
  }

  protected ControlNumberNotFoundException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
