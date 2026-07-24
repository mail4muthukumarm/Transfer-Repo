// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Exceptions.GLAccountNotFoundException
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Exceptions;

[Serializable]
public class GLAccountNotFoundException : Exception
{
  public GLAccountNotFoundException()
  {
  }

  public GLAccountNotFoundException(string message)
    : base(message)
  {
  }

  public GLAccountNotFoundException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected GLAccountNotFoundException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
