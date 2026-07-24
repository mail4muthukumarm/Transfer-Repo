// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.NoClaimantsSpecifiedException
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Claims;

[Serializable]
public class NoClaimantsSpecifiedException : Exception
{
  public NoClaimantsSpecifiedException()
  {
  }

  public NoClaimantsSpecifiedException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  public NoClaimantsSpecifiedException(string message)
    : base(message)
  {
  }

  protected NoClaimantsSpecifiedException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
