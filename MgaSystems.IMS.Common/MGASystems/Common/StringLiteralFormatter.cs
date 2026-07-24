// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.StringLiteralFormatter
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Globalization;

#nullable disable
namespace MGASystems.Common;

public class StringLiteralFormatter : IFormatProvider, ICustomFormatter
{
  private static IFormatProvider _thisProvider = (IFormatProvider) null;

  public string Format(string format1, object arg, IFormatProvider formatProvider)
  {
    format1 = format1 ?? string.Empty;
    return arg == null || arg == (object) string.Empty ? string.Empty : (format1.Contains("?") ? format1.Replace("?", arg.ToString()) : (!(arg is IFormattable) ? (arg == null ? string.Empty : arg.ToString()) : ((IFormattable) arg).ToString(format1, (IFormatProvider) CultureInfo.CurrentCulture)));
  }

  public object GetFormat(Type formatType)
  {
    return (object) formatType != (object) typeof (ICustomFormatter) ? (object) null : (object) this;
  }

  public static IFormatProvider Instance
  {
    get
    {
      if (StringLiteralFormatter._thisProvider == null)
        StringLiteralFormatter._thisProvider = (IFormatProvider) new StringLiteralFormatter();
      return StringLiteralFormatter._thisProvider;
    }
  }
}
