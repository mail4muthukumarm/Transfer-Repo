// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Exceptions.ErrorLoadingCostCenterException
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;

[Serializable]
public class ErrorLoadingCostCenterException : Exception
{
  public ErrorLoadingCostCenterException()
  {
  }

  public ErrorLoadingCostCenterException(string message)
    : base(message)
  {
  }

  public ErrorLoadingCostCenterException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected ErrorLoadingCostCenterException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }
}
