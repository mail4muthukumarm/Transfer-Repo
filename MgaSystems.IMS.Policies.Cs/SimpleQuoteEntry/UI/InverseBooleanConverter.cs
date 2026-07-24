// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.UI.InverseBooleanConverter
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.Globalization;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;

[ValueConversion(typeof (bool), typeof (bool))]
public class InverseBooleanConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
    if (targetType != typeof (bool))
      throw new InvalidOperationException("The target must be a boolean");
    return (object) !(bool) value;
  }

  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
    throw new NotSupportedException();
  }
}
