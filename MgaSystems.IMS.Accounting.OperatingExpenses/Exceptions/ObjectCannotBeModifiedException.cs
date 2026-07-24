// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Exceptions.ObjectCannotBeModifiedException
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;

[Serializable]
public class ObjectCannotBeModifiedException : Exception
{
  public ObjectCannotBeModifiedException()
  {
  }

  public ObjectCannotBeModifiedException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  public ObjectCannotBeModifiedException(string message)
    : base(message)
  {
  }

  protected ObjectCannotBeModifiedException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
