// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Extensions.ExceptionExtensions
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Extensions;

public static class ExceptionExtensions
{
  public static bool TryGetDataValue(
    this Exception exception,
    object dataKey,
    out object dataValue)
  {
    dataValue = (object) null;
    if (!exception.Data.Contains(dataKey))
      return false;
    dataValue = exception.Data[dataKey];
    return true;
  }

  public static bool TryGetDataValue<TValue>(
    this Exception exception,
    object dataKey,
    out TValue dataValue)
  {
    dataValue = default (TValue);
    if (!exception.Data.Contains(dataKey) || !(exception.Data[dataKey] is TValue obj))
      return false;
    dataValue = obj;
    return true;
  }

  public static object GetDataValue(this Exception exception, object dataKey)
  {
    object dataValue;
    exception.TryGetDataValue(dataKey, out dataValue);
    return dataValue;
  }

  public static TValue GetDataValue<TValue>(this Exception exception, object dataKey)
  {
    TValue dataValue;
    exception.TryGetDataValue<TValue>(dataKey, out dataValue);
    return dataValue;
  }

  public static void ThrowIfNullOrWhitespace(this string value, string parameterName)
  {
    if (string.IsNullOrWhiteSpace(value))
      throw new ArgumentException($"Invalid {parameterName} specified.", parameterName);
  }
}
