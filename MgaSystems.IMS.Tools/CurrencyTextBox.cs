// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CurrencyTextBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.UltraWinEditors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (TextBox))]
public class CurrencyTextBox : MGATextBox
{
  [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
  protected bool Hooked;

  protected virtual void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
  {
    if (cevent.Value == DBNull.Value)
      return;
    cevent.Value = (object) Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(cevent.Value));
  }

  protected virtual void CurrencyStringToDecimal(object sender, ConvertEventArgs cevent)
  {
    if (cevent.Value == DBNull.Value || (object) cevent.DesiredType != (object) typeof (Decimal))
      return;
    cevent.Value = (object) Decimal.Parse(cevent.Value.ToString(), NumberStyles.Currency, (IFormatProvider) null);
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override void Dispose(bool disposing)
  {
    if (this.Hooked)
    {
      try
      {
        // ISSUE: explicit non-virtual call
        Binding dataBinding = __nonvirtual (((Control) this).DataBindings)["Text"];
        if (dataBinding != null)
          dataBinding.Format -= new ConvertEventHandler(this.DecimalToCurrencyString);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    ((TextEditorControlBase) this).Dispose(disposing);
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override void OnTextChanged(EventArgs e)
  {
    ((TextEditorControlBase) this).OnTextChanged(e);
    if (this.Hooked)
      return;
    this.Hooked = true;
    try
    {
      // ISSUE: explicit non-virtual call
      Binding dataBinding = __nonvirtual (((Control) this).DataBindings)["Text"];
      if (dataBinding == null)
        return;
      dataBinding.Format += new ConvertEventHandler(this.DecimalToCurrencyString);
      dataBinding.Parse += new ConvertEventHandler(this.CurrencyStringToDecimal);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }
}
