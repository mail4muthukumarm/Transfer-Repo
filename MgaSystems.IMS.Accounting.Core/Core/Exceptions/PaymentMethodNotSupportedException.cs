// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Exceptions.PaymentMethodNotSupportedException
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Exceptions;

[Serializable]
public class PaymentMethodNotSupportedException : Exception
{
  public PaymentMethodNotSupportedException()
  {
  }

  public PaymentMethodNotSupportedException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  public PaymentMethodNotSupportedException(string message)
    : base(message)
  {
  }

  protected PaymentMethodNotSupportedException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
