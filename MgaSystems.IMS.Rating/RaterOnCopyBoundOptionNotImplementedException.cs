// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterOnCopyBoundOptionNotImplementedException
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[Serializable]
public sealed class RaterOnCopyBoundOptionNotImplementedException : Exception
{
  public RaterOnCopyBoundOptionNotImplementedException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  private RaterOnCopyBoundOptionNotImplementedException(
    SerializationInfo info,
    StreamingContext context)
    : base(info, context)
  {
  }

  public RaterOnCopyBoundOptionNotImplementedException()
    : base("OnCopyQuoteData has not been implemented on this rater.")
  {
  }

  public RaterOnCopyBoundOptionNotImplementedException(string message)
    : base(message)
  {
  }
}
