// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.Model.Validation.DataValidationGroupExtensions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.MVC.BaseClasses.Model.Exceptions;
using System;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.Model.Validation;

public static class DataValidationGroupExtensions
{
  public static bool ValidateIsNotNullOrEmpty(
    this DataValidationResultGroup resultGroup,
    string value,
    string friendlyPropertyName,
    bool useAn = false)
  {
    return DataValidationGroupExtensions.AddIfInvalid(resultGroup, !string.IsNullOrEmpty(value), friendlyPropertyName, (Func<IDataValidationResult>) (() => (IDataValidationResult) new EmptyValueDataValidationResult(friendlyPropertyName, useAn)));
  }

  public static bool ValidateIsExactLength(
    this DataValidationResultGroup resultGroup,
    string value,
    int expectedLength,
    string friendlyPropertyName)
  {
    return DataValidationGroupExtensions.AddIfInvalid(resultGroup, value.Length == expectedLength, friendlyPropertyName, (Func<IDataValidationResult>) (() => (IDataValidationResult) new InvalidLengthDataValidationResult(friendlyPropertyName, value.Length, expectedLength)));
  }

  public static bool ValidateHasSelection(
    this DataValidationResultGroup resultGroup,
    bool hasSelection,
    string friendlyPropertyName,
    bool useAn = false)
  {
    return DataValidationGroupExtensions.AddIfInvalid(resultGroup, hasSelection, friendlyPropertyName, (Func<IDataValidationResult>) (() => (IDataValidationResult) new DoesNotHaveSelectedValueResult(friendlyPropertyName, useAn)));
  }

  private static bool AddIfInvalid(
    DataValidationResultGroup resultGroup,
    bool isValid,
    string friendlyPropertyName,
    Func<IDataValidationResult> getInvalidResult)
  {
    if (!isValid)
    {
      resultGroup.Add(getInvalidResult());
      return false;
    }
    resultGroup.AddValidResult(friendlyPropertyName);
    return true;
  }

  private static void AddValidResult(
    this DataValidationResultGroup resultGroup,
    string friendlyPropretyName)
  {
    resultGroup.Add((IDataValidationResult) new ValidPropertyResult(friendlyPropretyName));
  }
}
