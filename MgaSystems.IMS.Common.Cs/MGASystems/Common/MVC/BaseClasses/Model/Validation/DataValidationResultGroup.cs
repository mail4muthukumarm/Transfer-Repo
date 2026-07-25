// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.Validation.DataValidationResultGroup
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.Validation;

public class DataValidationResultGroup : IDataValidationResult
{
  private List<IDataValidationResult> _results { get; } = new List<IDataValidationResult>();

  public string Message
  {
    get
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (IDataValidationResult validationResult in this._results.Where<IDataValidationResult>((Func<IDataValidationResult, bool>) (x => !x.IsValid)))
        stringBuilder.AppendLine(validationResult.Message);
      return stringBuilder.ToString();
    }
  }

  public void Add(IDataValidationResult result) => this._results.Add(result);

  public bool IsValid
  {
    get
    {
      return !this._results.Any<IDataValidationResult>((Func<IDataValidationResult, bool>) (x => !x.IsValid));
    }
  }
}
