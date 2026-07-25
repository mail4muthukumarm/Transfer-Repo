// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.FormattableNumericTextBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (TextBox))]
public sealed class FormattableNumericTextBox : CurrencyTextBox
{
  private NumberStyles _numberStyle;
  private string _formatString;

  public FormattableNumericTextBox()
  {
    this._numberStyle = NumberStyles.Currency;
    this._formatString = "c";
  }

  [DefaultValue(typeof (NumberStyles), "Currency")]
  public NumberStyles NumberStyle
  {
    get => this._numberStyle;
    set => this._numberStyle = value;
  }

  [DefaultValue("c")]
  public string FormatString
  {
    get => this._formatString;
    set => this._formatString = value;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override void CurrencyStringToDecimal(object sender, ConvertEventArgs cevent)
  {
    if (cevent.Value == DBNull.Value || (object) cevent.DesiredType != (object) typeof (Decimal) && (object) cevent.DesiredType != (object) typeof (int) && (object) cevent.DesiredType != (object) typeof (long) && (object) cevent.DesiredType != (object) typeof (float) && (object) cevent.DesiredType != (object) typeof (double))
      return;
    try
    {
      cevent.Value = (object) Decimal.Parse(cevent.Value.ToString(), this._numberStyle, (IFormatProvider) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      StringBuilder stringBuilder = new StringBuilder();
      string str = cevent.Value.ToString();
      int index = 0;
      while (index < str.Length)
      {
        char c = str[index];
        if (char.IsNumber(c) || Operators.CompareString(Conversions.ToString(c), ".", false) == 0)
          stringBuilder.Append(c);
        checked { ++index; }
      }
      cevent.Value = (object) Decimal.Parse(stringBuilder.ToString());
      ProjectData.ClearProjectError();
    }
  }

  protected override void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
  {
    if (cevent.Value == DBNull.Value)
      return;
    if (cevent.Value is int)
      cevent.Value = (object) ((int) cevent.Value).ToString(this._formatString);
    else if (cevent.Value is long)
      cevent.Value = (object) ((long) cevent.Value).ToString(this._formatString);
    else if (cevent.Value is float)
      cevent.Value = (object) ((float) cevent.Value).ToString(this._formatString);
    else if (cevent.Value is double)
    {
      cevent.Value = (object) ((double) cevent.Value).ToString(this._formatString);
    }
    else
    {
      if (!(cevent.Value is Decimal))
        return;
      cevent.Value = (object) ((Decimal) cevent.Value).ToString(this._formatString);
    }
  }
}
