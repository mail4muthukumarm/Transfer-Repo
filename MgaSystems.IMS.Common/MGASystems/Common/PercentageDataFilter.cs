// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.PercentageDataFilter
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common;

public class PercentageDataFilter : IEditorDataFilter
{
  public object Convert(EditorDataFilterConvertArgs conversionArgs)
  {
    ConversionDirection direction = conversionArgs.Direction;
    object obj;
    if (direction != 2)
    {
      if (direction == 3 && conversionArgs.Value != null && !(conversionArgs.Value is DBNull) && conversionArgs.Value is IConvertible)
      {
        if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(conversionArgs.Value)))
        {
          obj = (object) null;
          goto label_10;
        }
        Decimal num = System.Convert.ToDecimal(RuntimeHelpers.GetObjectValue(conversionArgs.Value));
        conversionArgs.Handled = true;
        obj = (object) num;
        goto label_10;
      }
    }
    else if (conversionArgs.Value != null && !(conversionArgs.Value is DBNull) && conversionArgs.Value is IConvertible)
    {
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(conversionArgs.Value)))
      {
        obj = (object) null;
        goto label_10;
      }
      Decimal num = System.Convert.ToDecimal(RuntimeHelpers.GetObjectValue(conversionArgs.Value));
      conversionArgs.Handled = true;
      obj = (object) System.Convert.ToInt32(num);
      goto label_10;
    }
    obj = (object) null;
label_10:
    return obj;
  }
}
