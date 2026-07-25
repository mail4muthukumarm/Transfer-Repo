// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.Validation.DataValidationException
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.Validation;

public class DataValidationException : Exception
{
  public DataValidationException(IDataValidationResult invalidResult)
    : base(invalidResult.Message)
  {
    if (invalidResult.IsValid)
      throw new InvalidOperationException("Cannot create a DataValidationException with a valid result!");
  }

  public DataValidationException(string message)
    : base(message)
  {
  }
}
